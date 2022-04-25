using Microsoft.EntityFrameworkCore;
using System;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {

        public DbSet<Enemy> Enemys { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = DESKTOP-957A0UD\\SQLEXPRESS; User id = sa; password=nabeel; Initial Catalog = DoctorWhoCore;");
        }
    }
}
