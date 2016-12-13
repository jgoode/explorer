using explorer_api.Data;
using explorer_api.Models;

namespace explorer_api.Repository
{
    public class SystemObjectRepository: EntityBaseRepository<SystemObject>, ISystemObjectRepository
    {
        public SystemObjectRepository(ApplicationDbContext context): base(context) { }

    }
}