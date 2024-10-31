using Microsoft.Extensions.Logging;
using NAMO.Application.Common;
using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.Application.Interfaces;
using NAMO.Domain.Entities;

namespace NAMO.Infrastructure.Services;

public class PatiVerService(
    ILogger<PatiVerService> logger,
    IWcfService client) : IPatiVerService
{
    //Никто не парился на счет защиты подобных данных, ну и я не стал
    private const string MoId = "999999";
    private const string Username = "miac";
    private const string Password = "0b56b6e8baeecb067b481e85e5328b74fb1f6bdc";
    private const bool IsIPRAFirst = false;
    private const int Mis = 11;

    private const string ProcessingStarted = "Начат поиск пациента в PatiVer";
    private const string Success = "Пациент найден";
    private const string NotFound = "Пациент не найден";

    public async Task<Result<PersonResponse>> GetPatientDataWithAttachmentFromFOMSAsync(GetAvailableMoIdsQuery query)
    {
        logger.LogInformation(ProcessingStarted);

        Result<PersonResponse> response = await TryGetPersonInfoAsync(() =>
            client.GetPersonInfo_FIOAsync(MoId, query.LastName, query.FirstName, query.MiddleName,
            query.ParsedBirthDate.ToString(), Username, Password, IsIPRAFirst, Mis),
            "ФИО");

        if (response.IsSuccess) return response!;

        response = await TryGetPersonInfoAsync(() =>
            client.GetPersonInfo_PolisAsync(MoId, query.Polis, Username, Password, IsIPRAFirst, Mis),
            "Полис");

        if (response.IsSuccess) return response!;

        response = await TryGetPersonInfoAsync(() =>
            client.GetPersonInfo_SNILSAsync(MoId, query.SNILS, Username, Password, IsIPRAFirst, Mis),
            "Снилс");

        if (response.IsSuccess) return response!;

        logger.LogInformation(NotFound);
        return Result<PersonResponse>.Failure();
    }

    private async Task<Result<PersonResponse>> TryGetPersonInfoAsync(Func<Task<PersonResponse>> getPersonInfo, string requestType)
    {
        PersonResponse response = await getPersonInfo();
        // Если не найдено или нет припрепления
        if (response.SearchResult == "1" || !string.IsNullOrEmpty(response.AttachmentData.CodeMO))
        {
            logger.LogInformation($"{Success} из запроса по {requestType}");
            return Result<PersonResponse>.Success(response);
        }

        return Result<PersonResponse>.Failure();
    }
}
