using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIDAsync(int Id);
        Task AddAsync(T entity);
        Task UpdateAsync(int Id, T entity);
        Task DeleteAsync(int Id);
    }
}
