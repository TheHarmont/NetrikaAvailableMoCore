using Microsoft.EntityFrameworkCore;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Domain.Entities.dbEntities;
using NAMO.Persistence.Context;

namespace NAMO.Persistence.Repositories
{
    public class MORepository : IMORepository
    {
        private readonly ApplicationDBContext _dbContext;

        public MORepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MoList>> GetAllMOsAsync()
        {
            try
            {
                return await _dbContext.MoLists.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task<List<MoList>> GetAttachmentMOsAsync(string? codeMO)
        {
            try
            {
                var attachmentMOs = await _dbContext.MoLists.
                    AsNoTracking().
                    Where(x => x.IsActive && x.OnlyAttachment && x.CodeMO == codeMO).
                    ToListAsync();
                if(!attachmentMOs.Any())
                {
                    throw new Exception($"Не найдены прикрепления по коду: {codeMO}");
                }

                return attachmentMOs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<MoList>> GetNonAttachmentMOsAsync()
        {
            try
            {
                return await _dbContext.MoLists.
                    AsNoTracking().
                    Where(x => x.IsActive && !x.OnlyAttachment).
                    ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<MoList>> GetObligatoryMOAsync()
        {
            try
            {
                return await _dbContext.MoLists.
                    AsNoTracking().
                    Where(x => x.IsActive && x.DisplayAny).
                    ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
