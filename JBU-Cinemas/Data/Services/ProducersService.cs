using JBU_Cinemas.Data.Base;
using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context){}
    }
}
