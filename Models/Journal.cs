using System;
namespace explorer_api.Models
{
    public class Journal: IEntityBase
    {
        public int Id { get; set; }

        public string JsonData { get; set; }

        public int JournalFileId { get; set; }

        public JournalFile JournalFile { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }
    }
}