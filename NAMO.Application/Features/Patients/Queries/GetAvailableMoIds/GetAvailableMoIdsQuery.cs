using MediatR;
using Microsoft.Extensions.Logging;
using NAMO.Application.Exceptions;
using NAMO.Application.Interfaces;
using NAMO.Domain.Common;
using NAMO.Domain.Entities;
using NLog;

namespace NAMO.Application.Features.Patients.Queries.GetAvailableMoIds
{
    public record GetAvailableMoIdsQuery : IRequest<GetAvailableMoIdsDto>
    {
        public PatientInfoRequest Request { get; set; }

        public GetAvailableMoIdsQuery(PatientInfoRequest request)
        {
            Request = request;
        }
    }

    internal class GetAvailableMoIdsHandler : IRequestHandler<GetAvailableMoIdsQuery, GetAvailableMoIdsDto>
    {
        private readonly ILogger<GetAvailableMoIdsHandler> _logger;

        private readonly IAvailableMOService _availableMOService;
        private readonly ISeparatePersonsService _SeparatePersonsService;
        private readonly IPatiVerService _patiVerService;

        public GetAvailableMoIdsHandler(ILogger<GetAvailableMoIdsHandler> logger, IAvailableMOService availableMOService, ISeparatePersonsService separatePersonsService, IPatiVerService patiVerService)
        {
            _logger = logger;

            _availableMOService = availableMOService;
            _SeparatePersonsService = separatePersonsService;
            _patiVerService = patiVerService;
        }

        public async Task<GetAvailableMoIdsDto> Handle(GetAvailableMoIdsQuery query, CancellationToken cancellationToken)
        {
            var patient = query.Request;

            using (ScopeContext.PushProperty("OperationHash", OperationHash.GetHash(patient)))
            {
                try
                {
                    _logger.LogInformation($"Начата обработка запроса (ФИО: {patient.FirstName} {patient.LastName} {patient.MiddleName} {patient.BirthDate}| ПОЛИС: {patient.Polis} СНИЛС: {patient.SNILS})");

                    if (!patient.IsValid()) throw new AvailableMoQueryException("Данные не прошли валидацию");

                    //Для людей, относящихся к отдельной группе лиц, выполняем отдельный запрос в БД
                    var moIds = await _SeparatePersonsService.GetAvailableMoAsync(patient.Polis);
                    if (moIds?.Count() > 0) return GenerateResult(moIds);

                    //Для всех остальных пациентов нужно выполнить верификацию,
                    //получить их прикрепление и отфильтровать список МО по входным параметрам

                    //Получаем информацию о пациенте
                    var patientInfo = _patiVerService.GetPersonResponseDTOByFIO(patient);

                    if (patientInfo is null) throw new AvailableMoQueryException("Пациент не найден");
                    if (string.IsNullOrEmpty(patientInfo?.AttachmentData?.CodeMO)) throw new AvailableMoQueryException("У пациента нет прикрепления");

                    //Если входящие ПОЛИС и СНИЛС совпадают с ПОЛИСом и СНИЛСом из ФОМС (Требование заказчика)
                    if (patientInfo?.PolisData?.Num != patient.Polis && !patient.SNILS.SnilsEquals(patientInfo?.PatientData?.Snils)) throw new AvailableMoQueryException("СНИЛС и ПОЛИС не прошли проверку");

                    var availableMO = await _availableMOService.GetAvailableMO(patientInfo, patient);

                    return GenerateResult(availableMO);
                }
                catch (AvailableMoQueryException ex)
                {
                    _logger.LogInformation($"Обработка отменена из-за: {ex.Message}");

                    return GenerateResult(null);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Во время выполнения запроса произошла непредвиденная ошибка: {ex.Message}");

                    return GenerateResult(null);
                }
            }
        }

        private GetAvailableMoIdsDto GenerateResult(List<int>? moIds)
        {
            _logger.LogInformation($"Возвращено: {(moIds?.Count() > 0 ? string.Join(",", moIds.ToArray()) : "null")}");

            return new GetAvailableMoIdsDto
            {
                Organisations = moIds,
                Status = 0,
                Message = null
            };
        }
    }

}
