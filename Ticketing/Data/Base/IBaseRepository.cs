using Ticketing.Models;

namespace Ticketing.Data.Base
{
    public interface IBaseRepository<T> where T : class , IBaseEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
