using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Application.Interfaces.Repositories
{
    public interface ISeparatePersonsRepository
    {
        /// <summary>
        /// Возвращает сипсок, соответствующий указанному <paramref name="polis" />
        /// </summary>
        public Task<List<SeparatePerson>> GetSeparatePersonsByPolisAsync(string? polis);
    }
}
