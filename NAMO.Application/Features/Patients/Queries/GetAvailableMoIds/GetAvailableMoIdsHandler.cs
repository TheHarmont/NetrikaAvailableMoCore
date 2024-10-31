using MediatR;
using Microsoft.Extensions.Logging;
using NAMO.Application.Common;
using NAMO.Application.Interfaces;
using NAMO.Domain.Entities;

namespace NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;

internal class GetAvailableMoIdsHandler
    (ILogger<GetAvailableMoIdsHandler> logger,
    IAvailableMOService availableMOService,
    ISeparatePersonsService separatePersonsService,
    IPatiVerService patiVerService) : IRequestHandler<GetAvailableMoIdsQuery, Result<List<int>>>
{
    private const string InvalidSnils = "Полис и СНИЛС из запроса не совпадают с данными ФОМС";

    public async Task<Result<List<int>>> Handle(GetAvailableMoIdsQuery query, CancellationToken cancellationToken)
    {
        // Проверка для отдельной группы лиц
        var separateResult = await separatePersonsService.GetAvailableMoIdsAsync(query.Polis);
        if (separateResult.IsSuccess) return separateResult;

        try
        {
            // Получаем данные пациента
            var patientInfoResult = await patiVerService.GetPatientDataWithAttachmentFromFOMSAsync(query);
            if (!patientInfoResult.IsSuccess) return Result<List<int>>.Failure();

            // Проверка соответствия данных полиса и СНИЛС с требованиями
            if (!ValidatePolisAndSnils(query, patientInfoResult.Data))
            {
                logger.LogWarning(InvalidSnils);
                return Result<List<int>>.Failure();
            }

            // Получение и фильтрация доступных МО
            var availableMoIds = await availableMOService.GetAvailableMOIdsAsync(patientInfoResult.Data, query);
            return Result<List<int>>.Success(availableMoIds);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return Result<List<int>>.Failure();
        }
    }

    private bool ValidatePolisAndSnils(GetAvailableMoIdsQuery query, PersonResponse patientData)
    {
        return patientData.PolisData.Num == query.Polis || query.SNILS.SnilsEquals(patientData.PatientData.Snils);
    }
}
