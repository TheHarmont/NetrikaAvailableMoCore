using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.Domain.Entities;

namespace NAMO.Application.Interfaces;

public interface IAvailableMOService
{
    /// <summary>
    /// Возвращает список идентификаторов доступных МО
    /// </summary>
    public Task<List<int>> GetAvailableMOIdsAsync(PersonResponse patientInfo, GetAvailableMoIdsQuery query);
}
