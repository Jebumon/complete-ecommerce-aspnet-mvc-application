using JBU_Cinemas.Models;
using System.Linq.Expressions;

namespace JBU_Cinemas.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIDAsync(int Id);
        Task AddAsync(T entity);
        Task UpdateAsync(int Id, T entity);
        Task DeleteAsync(int Id);
    }
}
