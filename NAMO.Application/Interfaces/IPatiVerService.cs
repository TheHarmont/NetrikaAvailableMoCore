using NAMO.Application.Common;
using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.Domain.Entities;

namespace NAMO.Application.Interfaces;

public interface IPatiVerService
{
    /// <summary>
    /// Возвращает результат, содержащий данные о пользователе.
    /// </summary>
    public Task<Result<PersonResponse>> GetPatientDataWithAttachmentFromFOMSAsync(GetAvailableMoIdsQuery query);
}
