using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIDAsync(int actorId);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int actorId, Actor newActor);
        Task  DeleteAsync(int actorId);
    }
}
