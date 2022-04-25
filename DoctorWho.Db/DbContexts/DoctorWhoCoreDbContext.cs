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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>()
                .HasData(
                    new Author { AuthorId = 1, AuthorName = "Nabeel" },
                    new Author { AuthorId = 2, AuthorName = "Kayed" },
                    new Author { AuthorId = 3, AuthorName = "Ahmad" },
                    new Author { AuthorId = 4, AuthorName = "samer" },
                    new Author { AuthorId = 5, AuthorName = "sameer" }
                    );
            modelBuilder.Entity<Companion>()
                .HasData(
                    new Companion { CompanionId = 1, CompanionName = "Nabeel", WhoPlayed = "kayed" },
                    new Companion { CompanionId = 2, CompanionName = "Kayed", WhoPlayed = "nabeel" },
                    new Companion { CompanionId = 3, CompanionName = "Ahmad", WhoPlayed = "Samer" },
                    new Companion { CompanionId = 4, CompanionName = "Samer", WhoPlayed = "Ahmad" },
                    new Companion { CompanionId = 5, CompanionName = "Sameer", WhoPlayed = "Samer" }
                    );
            modelBuilder.Entity<Doctor>()
                .HasData(
                    new Doctor
                    {
                        DoctorId = 1,
                        DoctorNumber = 1,
                        DoctorName = "Nabeel",
                        BirthDate = Convert.ToDateTime("2010/12/10"),
                        FirstEpisodeDate = Convert.ToDateTime("2010/12/10"),
                        LastEpisodeDate = Convert.ToDateTime("2010/12/15")
                    },
                    new Doctor
                    {
                        DoctorId = 2,
                        DoctorNumber = 12,
                        DoctorName = "Kayed",
                        BirthDate = Convert.ToDateTime("2010/12/11"),
                        FirstEpisodeDate = Convert.ToDateTime("2010/12/12"),
                        LastEpisodeDate = Convert.ToDateTime("2010/12/16")
                    },
                    new Doctor
                    {
                        DoctorId = 3,
                        DoctorNumber = 123,
                        DoctorName = "Ahmad",
                        BirthDate = Convert.ToDateTime("2010/12/12"),
                        FirstEpisodeDate = Convert.ToDateTime("2010/12/14"),
                        LastEpisodeDate = Convert.ToDateTime("2010/12/20")
                    },
                    new Doctor
                    {
                        DoctorId = 4,
                        DoctorNumber = 1234,
                        DoctorName = "Samer",
                        BirthDate = Convert.ToDateTime("2010/12/13"),
                        FirstEpisodeDate = Convert.ToDateTime("2010/12/19"),
                        LastEpisodeDate = Convert.ToDateTime("2010/12/25")
                    },
                    new Doctor
                    {
                        DoctorId = 5,
                        DoctorNumber = 12345,
                        DoctorName = "Sameer",
                        BirthDate = Convert.ToDateTime("2010/12/14"),
                        FirstEpisodeDate = Convert.ToDateTime("2010/12/17"),
                        LastEpisodeDate = Convert.ToDateTime("2010/12/29")
                    });

            modelBuilder.Entity<Enemy>()
             .HasData(
                 new Enemy { EnemyId = 1, EnemyName = "Nabeel", EnemyDescription = "kayed" },
                 new Enemy { EnemyId = 2, EnemyName = "Kayed", EnemyDescription = "nabeel" },
                 new Enemy { EnemyId = 3, EnemyName = "Ahmad", EnemyDescription = "Samer" },
                 new Enemy { EnemyId = 4, EnemyName = "Samer", EnemyDescription = "Ahmad" },
                 new Enemy { EnemyId = 5, EnemyName = "Sameer", EnemyDescription = "Samer" }
                 );

            modelBuilder.Entity<Episode>()
             .HasData(
                 new Episode
                 {
                     EpisodeId = 1,
                     SeriesNumber = 1,
                     EpisodeNumber = 1,
                     EpisodeType = "A",
                     Title = "EP1",
                     EpisodeDate = Convert.ToDateTime("2010/12/10"),
                     AuthorId = 1,
                     DoctorId = 5,
                     Nots = "n5"
                 },
                 new Episode
                 {
                     EpisodeId = 2,
                     SeriesNumber = 12,
                     EpisodeNumber = 21,
                     EpisodeType = "B",
                     Title = "EP2",
                     EpisodeDate = Convert.ToDateTime("2010/12/12"),
                     AuthorId = 1,
                     DoctorId = 5,
                     Nots = "n5"
                 },
                 new Episode
                 {
                     EpisodeId = 3,
                     SeriesNumber = 123,
                     EpisodeNumber = 321,
                     EpisodeType = "C",
                     Title = "EP3",
                     EpisodeDate = Convert.ToDateTime("2010/12/14"),
                     AuthorId = 2,
                     DoctorId = 4,
                     Nots = "n5"
                 },
                 new Episode
                 {
                     EpisodeId = 4,
                     SeriesNumber = 1234,
                     EpisodeNumber = 4321,
                     EpisodeType = "D",
                     Title = "EP4",
                     EpisodeDate = Convert.ToDateTime("2010/12/19"),
                     AuthorId = 2,
                     DoctorId = 4,
                     Nots = "n5"
                 },
                 new Episode
                 {
                     EpisodeId = 5,
                     SeriesNumber = 12345,
                     EpisodeNumber = 43215,
                     EpisodeType = "E",
                     Title = "EP5",
                     EpisodeDate = Convert.ToDateTime("2010/12/17"),
                     AuthorId = 3,
                     DoctorId = null,
                     Nots = "n5"
                 }
                 );

            modelBuilder.Entity<EpisodeCompanion>()
            .HasData(
               new EpisodeCompanion { EpisodeCompanionId = 1, EpisodeId = 1, CompanionId = 1 },
               new EpisodeCompanion { EpisodeCompanionId = 2, EpisodeId = 2, CompanionId = 2 },
               new EpisodeCompanion { EpisodeCompanionId = 3, EpisodeId = 3, CompanionId = 3 },
               new EpisodeCompanion { EpisodeCompanionId = 4, EpisodeId = 4, CompanionId = 3 },
               new EpisodeCompanion { EpisodeCompanionId = 5, EpisodeId = 5, CompanionId = 5 },
               new EpisodeCompanion { EpisodeCompanionId = 6, EpisodeId = 1, CompanionId = 1 }
             );

            modelBuilder.Entity<EpisodeEnemy>()
            .HasData(
               new EpisodeEnemy { EpisodeEnemyId = 1, EpisodeId = 1, EnemyId = 1 },
               new EpisodeEnemy { EpisodeEnemyId = 2, EpisodeId = 2, EnemyId = 2 },
               new EpisodeEnemy { EpisodeEnemyId = 3, EpisodeId = 3, EnemyId = 3 },
               new EpisodeEnemy { EpisodeEnemyId = 4, EpisodeId = 4, EnemyId = 4 },
               new EpisodeEnemy { EpisodeEnemyId = 5, EpisodeId = 5, EnemyId = 5 },
               new EpisodeEnemy { EpisodeEnemyId = 6, EpisodeId = 1, EnemyId = 1 }
         );

        }
    }
}
