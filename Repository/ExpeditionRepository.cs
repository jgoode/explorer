using explorer_api.Data;
using explorer_api.Models;

namespace explorer_api.Repository
{
    public class ExpeditionRepository: EntityBaseRepository<Expedition>, IExpeditionRepository
    {
        public ExpeditionRepository(ApplicationDbContext context) : base(context) { }
    }
}