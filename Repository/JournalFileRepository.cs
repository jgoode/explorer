
using explorer_api.Data;
using explorer_api.Models;

namespace explorer_api.Repository {
    public class JournalFileRepository: EntityBaseRepository<JournalFile>, IJournalFileRepository {
        public JournalFileRepository(ApplicationDbContext context) : base(context) { }
    }
}