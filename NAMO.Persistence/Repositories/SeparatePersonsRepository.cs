using Microsoft.EntityFrameworkCore;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Domain.Entities.dbEntities;
using NAMO.Persistence.Context;

namespace NAMO.Persistence.Repositories;

public class SeparatePersonsRepository(IGenericRepository<SeparatePerson> repository) 
    : ISeparatePersonsRepository
{
    public async Task<List<SeparatePerson>> GetSeparatePersonsByPolisAsync(string? polis)
    {
        return await repository.Entities.
            AsNoTracking().
            Where(x => x.Policy == polis).
            ToListAsync();
    }
}
