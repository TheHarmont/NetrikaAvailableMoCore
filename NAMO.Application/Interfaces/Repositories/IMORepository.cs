using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Application.Interfaces.Repositories;

public interface IMORepository
{
    /// <summary>
    /// Возвращает список актуальных МО, код которых соответствует коду прикрепления пациента
    /// </summary>
    public Task<List<MO>> GetOnlyAttachmentAndActiveMOsByCodeMoAsync(string? codeMO);

    /// <summary>
    /// Возвращает список актуальных МО, работающих без прикрепления
    /// </summary>
    public Task<List<MO>> GetNonAttachmentAndActiveMOsAsync();

    /// <summary>
    /// Возвращает список актуальных МО, которые обязательно должны попасть в ответ.
    /// </summary>
    public Task<List<MO>> GetDisplayAnyMOAsync();
}
