using JBU_Cinemas.Data.Base;
using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data.Services
{
    public class CinemaService: EntityBaseRepository<Cinema> , ICinemaService
    {
        public CinemaService(AppDbContext context) : base(context) { }
        
    }
}
