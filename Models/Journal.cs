using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using explorer_api.Models;
using System;

namespace explorer_api.Models
{
    public class Journal
    {
        public int Id { get; set; }

        public string JsonData { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }

        public int JournalFileId { get; set; }

        public JournalFile JournalFile { get; set; }
    }
}