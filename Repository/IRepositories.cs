using explorer_api.Models;

namespace explorer_api.Repository {
    public interface IJournalFileRepository: IEntityBaseRepository<JournalFile> { }
    
    public interface IJournalRepository: IEntityBaseRepository<Journal> { }
}