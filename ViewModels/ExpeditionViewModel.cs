using System;

namespace explorer_api.ViewModels
{
    public class ExpeditionViewModel
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

        public string UserId { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }
    }
}