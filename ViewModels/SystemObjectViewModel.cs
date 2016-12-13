using System;
using explorer_api.Models;

namespace explorer_api.ViewModels
{
    public class SystemObjectViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Distance { get; set; }

        public string StarType { get; set; }

        public double Radius { get; set; }

        public double AbsMagnitude { get; set; }

        public double RotationalPeriod { get; set; }

        public double AgeMy { get; set; }

        public int TidalLock { get; set; }

        public string TerraformState { get; set; }

        public string PlanetClass { get; set; }

        public string Atmosphere { get; set; }

        public string Volcanism { get; set; }

        public double SurfaceGravity { get; set; }

        public double SurfaceTemp { get; set; }

        public double SurfacePressure { get; set; }

        public bool Landable { get; set; }

        public double SemiMajorAxis { get; set; }

        public double Eccentricity { get; set; }

        public double OribitalInclination { get; set; }

        public double Periapsis { get; set; }

        public double OrbitalPeriod { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }

        public StarSystem StarSystem { get; set; }

        public int StarSystemId { get; set; }
    }
}