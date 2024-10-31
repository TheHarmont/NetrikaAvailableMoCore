using Microsoft.Extensions.Logging;
using NAMO.Application.Common;
using NAMO.Application.Interfaces;
using NAMO.Application.Interfaces.Repositories;

namespace NAMO.Infrastructure.Services;

public class SeparatePersonsService(
    ILogger<SeparatePersonsService> logger,
    ISeparatePersonsRepository repository) : ISeparatePersonsService
{
    private const string Success = "Пациент найден в особой группе лиц";

    public async Task<Result<List<int>>> GetAvailableMoIdsAsync(string? polis)
    {
        try
        {
            var separatePersons = await repository.GetSeparatePersonsByPolisAsync(polis);

            if (separatePersons is null || separatePersons.Count == 0)return Result<List<int>>.Failure();

            //Найдено больше одной записи
            if (separatePersons.Count > 1)return Result<List<int>>.Failure();

            var moList = separatePersons.First()?.MoList;
            if (string.IsNullOrEmpty(moList))return Result<List<int>>.Failure();

            var result = moList.Split(',')
                               .Select(x => int.TryParse(x, out var id) ? id : (int?)null)
                               .Where(id => id.HasValue)
                               .Select(id => id.Value)
                               .ToList();

            if (result.Count == 0) return Result<List<int>>.Failure();

            logger.LogInformation(Success);
            return Result<List<int>>.Success(result);
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, ex.Message);
            return Result<List<int>>.Failure();
        }
        
    }
}
