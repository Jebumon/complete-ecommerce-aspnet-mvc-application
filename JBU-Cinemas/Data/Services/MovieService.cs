using JBU_Cinemas.Data.Base;
using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data.Services
{
    public class MovieService: EntityBaseRepository<Movie>, IMovieService
    {
        public MovieService(AppDbContext context): base(context) { }
        
    }
}
