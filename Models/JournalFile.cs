using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using explorer_api.Models;
using System;

namespace explorer_api.Models {
    public class JournalFile: IEntityBase {
        public int Id { get; set; }

        public string FileName { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User {get; set;}


    }
}