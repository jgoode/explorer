using explorer_api.Data;
using explorer_api.Models;

namespace explorer_api.Repository
{
    public class StarSystemRepository: EntityBaseRepository<StarSystem>, IStarSystemRepository
    {
        public StarSystemRepository(ApplicationDbContext context): base(context) { }
    }
}