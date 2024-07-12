using Microsoft.EntityFrameworkCore;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Domain.Entities.dbEntities;
using NAMO.Persistence.Context;

namespace NAMO.Persistence.Repositories
{
    public class SeparatePersonsRepository : ISeparatePersonsRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public SeparatePersonsRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> SeparatePersonIsExistAsync(string polis)
        {
            try
            {
                var separatePerson = await _dbContext.SeparatePersons.
                    AsNoTracking().
                    FirstOrDefaultAsync(x => x.Policy == polis);
                return separatePerson != null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<SeparatePerson?> GetSeparatePersonByPolisAsync(string? polis)
        {
            try
            {
                return await _dbContext.SeparatePersons.
                    AsNoTracking().
                    FirstOrDefaultAsync(x => x.Policy == polis);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
