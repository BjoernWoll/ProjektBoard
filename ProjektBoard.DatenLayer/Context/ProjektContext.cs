using Microsoft.EntityFrameworkCore;
using ProjektBoard.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektBoard.DatenLayer.Context
{
    public class ProjektContext : DbContext
    {
        public DbSet<Projekt> Projekte { get; set; }
        public DbSet<Status> Stati { get; set; }
        public DbSet<ProjektStatus> ProjektStati { get; set; }
        public DbSet<Person> Personen { get; set; }
      //  public DbSet<ProjektTeam> ProjektTeams { get; set; }

        public ProjektContext(DbContextOptions<ProjektContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjektStatus>()
                .HasKey(e => e.id);
        }
    }
}
