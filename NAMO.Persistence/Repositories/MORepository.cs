using Microsoft.EntityFrameworkCore;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Persistence.Repositories;

public class MORepository(IGenericRepository<MO> repository)
    : IMORepository
{
    public async Task<List<MO>> GetOnlyAttachmentAndActiveMOsByCodeMoAsync(string? codeMO)
    {
        return await repository.Entities.
            AsNoTracking().
            Where(x =>
                x.IsActive &&
                x.OnlyAttachment &&
                x.CodeMO == codeMO).
            ToListAsync();
    }

    public async Task<List<MO>> GetNonAttachmentAndActiveMOsAsync()
    {
        return await repository.Entities.
            AsNoTracking().
            Where(x =>
                x.IsActive &&
                !x.OnlyAttachment).
            ToListAsync();
    }

    public async Task<List<MO>> GetDisplayAnyMOAsync()
    {
        return await repository.Entities.
            AsNoTracking().
            Where(x =>
                x.IsActive &&
                x.DisplayAny).
            ToListAsync();
    }
}
