using System;

namespace explorer_api.Models
{
    public class Expedition: IEntityBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Distance { get; set; }

        public int Jumps { get; set; }

        public double BaseCredits { get; set; }

        public double BonusCredits { get; set; }

        public double TotalCredits { get; set; }

        public int UserId { get; set; }
        
        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }
    }
}