using JBU_Cinemas.Data.Base;
using JBU_Cinemas.Models;
using Microsoft.EntityFrameworkCore;

namespace JBU_Cinemas.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}
