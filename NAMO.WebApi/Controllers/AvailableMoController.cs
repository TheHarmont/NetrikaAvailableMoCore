using MediatR;
using Microsoft.AspNetCore.Mvc;
using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.WebApi.Common;
using NLog;
using System.Text.Json;

namespace NAMO.WebApi.Controllers;

public class AvailableMoController
    (IHttpContextAccessor httpContextAccessor,
    IMediator mediator) : ApiControllerBase
{
    private const string RequestStarted = "Начало выполнения запроса";
    private const string RequestFinished = "Запрос завершился";

    private const string RequestInvalid = "Пациент не прошел валидацию";

    private static Logger _logger = LogManager.GetCurrentClassLogger();

    [HttpPost]
    public async Task<object> GetAvailableMoIds([FromBody] GetAvailableMoIdsQuery query)
    {
        using (CustomLogger.FillInСustomLogs(httpContextAccessor))
        {
            LogRequestStarted(query);

            var validastor = new GetAvailableMoIdsValidator();
            bool isValid = validastor.Validate(query);

            if (!isValid) LogAndReturnFailure(RequestInvalid);

            var result = await mediator.Send(query);

            return result.IsSuccess ? LogAndReturnSuccess(result.Data) : LogAndReturnFailure(RequestFinished);
        }
    }

    /// <summary>
    /// Записывает начальный лог
    /// </summary>
    private void LogRequestStarted(GetAvailableMoIdsQuery query)
    {
        var logEvent = new LogEventInfo(NLog.LogLevel.Info, null, $"{RequestStarted}");
        // Добавляем в лог параметр "message-data", хранящий входные данные
        logEvent.Properties["message-data"] = string.Join(JsonSerializer.Serialize(new
        {
            query.PolisS,
            query.PolisN,
            query.FirstName,
            query.LastName,
            query.MiddleName,
            query.BirthDate,
            query.Sex,
            query.SNILS,
        }));
        _logger.Log(logEvent);
    }

    private GetAvailableMoIdsDto LogAndReturnSuccess(List<int> moIds)
    {
        var request =
            new GetAvailableMoIdsDto
            {
                Organisations = moIds,
                Status = 0,
                Message = null
            };

        var logEvent = new LogEventInfo(NLog.LogLevel.Info, null, $"{RequestStarted}");
        // Добавляем в лог параметр "message-data", хранящий выходные данные
        logEvent.Properties["message-data"] = string.Join(JsonSerializer.Serialize(request));
        _logger.Log(logEvent);
        return request;
    }

    private GetAvailableMoIdsDto LogAndReturnFailure(string message, Exception? ex = null)
    {
        var emptyRequest =
            new GetAvailableMoIdsDto
            {
                Organisations = new(),
                Status = 0,
                Message = null
            };

        if (ex is null)
        {
            var logEvent = new LogEventInfo(NLog.LogLevel.Info, null, $"{RequestStarted}");
            // Добавляем в лог параметр "message-data", хранящий выходные данные
            logEvent.Properties["message-data"] = string.Join(JsonSerializer.Serialize(emptyRequest));
            _logger.Log(logEvent);
        }
        else
        {
            _logger.Error(message, ex);
        }

        return emptyRequest;
    }
}
