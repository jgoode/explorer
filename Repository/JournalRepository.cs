using explorer_api.Data;
using explorer_api.Models;

namespace explorer_api.Repository {
    public class JournalRepository: EntityBaseRepository<Journal>, IJournalRepository {
        public JournalRepository(ApplicationDbContext context): base(context) { }
    }
}