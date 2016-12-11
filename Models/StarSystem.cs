using System;

namespace explorer_api.Models
{
    public class StarSystem: IEntityBase
    {
        public int Id { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public string Allegiance { get; set; }

        public string Government { get; set; }

        public string Economy { get; set; }

        public string Security { get; set; }

        public double JumpDistance { get; set; }

        public double FuleUsed { get; set; }

        public double FuelUsed { get; set; }

        public int ExpeditionId { get; set; }

        public Expedition Expedition { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }
    }
}