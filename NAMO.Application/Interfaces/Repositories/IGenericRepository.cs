namespace NAMO.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    IQueryable<T> Entities { get; }
}
