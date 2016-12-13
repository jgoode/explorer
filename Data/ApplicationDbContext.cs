using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using explorer_api.Models;
using Microsoft.Extensions.Configuration;

namespace explorer_api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<JournalFile> JournalFiles { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<StarSystem> StarSystems { get; set; }
        public DbSet<SystemObject> SystemObjects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("EXPLORER_CONNECTION_STRING");
               
            optionsBuilder.UseNpgsql(connectionString);
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<JournalFile>()
                .HasAlternateKey(c => c.FileName)
                .HasName("AlternateKey_FileName");

            builder.Entity<StarSystem>()
                .HasOne(p => p.Expedition)
                .WithMany(p => p.StarSystems)
                .HasForeignKey(p => p.ExpeditionId);

            builder.Entity<SystemObject>()
                .HasOne(p => p.StarSystem)
                .WithMany(p => p.SystemObjects)
                .HasForeignKey(p => p.StarSystemId);
        }
    }
}
