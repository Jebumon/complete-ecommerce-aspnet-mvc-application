using EntityFrameworkCore.Diagrams.Dto;
using JBU_Cinemas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JBU_Cinemas.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity) 
        { 
            await _context.Set<T>().AddAsync(entity); 
            await _context.SaveChangesAsync();
        }
        

        public async Task DeleteAsync(int Id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == Id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
            

        public async Task<T> GetByIDAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);


        public async Task UpdateAsync(int Id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
