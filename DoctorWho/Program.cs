using DoctorWho.Db;
using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        static void Main(string[] args)
        {
            var Companions = fnCompanions();
            var Enemies = fnEnemies();
            var Episodes = viewEpisodes();

            var Doctors = GetAllDoctors();
            var enemy = GetEnemyById(1);
            var companion = GetCompanionById(1);

        }
        private static List<spSummariseEpisodes> spSummariseEpisodes()
        {
            return _context.spSummariseEpisodes.FromSqlRaw("EXEC spSummariseEpisodes;").ToList();
        } 
        private static List<fnCompanions> fnCompanions()
        {
            return _context.fnCompanions.FromSqlRaw("SELECT * from dbo.fnCompanions(1);").ToList();
        }
        private static List<fnEnemies> fnEnemies()
        {
            return _context.fnEnemies.FromSqlRaw("SELECT * from dbo.fnEnemies(1);").ToList();
        }
        private static List<viewEpisodes> viewEpisodes()
        {
            return _context.viewEpisodes.FromSqlRaw("select * from viewEpisodes;").ToList();
        }
        private static void CreateAuthors(string AuthorName)
        {
            var Author = new Author { AuthorName = AuthorName };
            _context.Authors.Add(Author);
            _context.SaveChanges();
        }
        private static void UpdateAuthors(int AuthorId)
        {
            var Author = _context.Authors.Find(AuthorId);
            Author.AuthorName += "Kayed";
            _context.SaveChanges();
        }
        private static void DeleteAuthors(int AuthorId)
        {
            var Author = _context.Authors.Find(AuthorId);
            _context.Authors.Remove(Author);
            _context.SaveChanges();
        }
        private static void CreateCompanions(string CompanionName, string WhoPlayed)
        {
            var Companion = new Companion { CompanionName = CompanionName, WhoPlayed = WhoPlayed };
            _context.Companions.Add(Companion);
            _context.SaveChanges();
        }
        private static void UpdateCompanions(int CompanionId)
        {
            var Companion = _context.Companions.Find(CompanionId);
            Companion.CompanionName += "Kayed";
            _context.SaveChanges();
        }
        private static void DeleteCompanions(int CompanionId)
        {
            var Companion = _context.Companions.Find(CompanionId);
            _context.Companions.Remove(Companion);
            _context.SaveChanges();
        }

        private static void CreateDoctors(int DoctorNumber, string DoctorName,
                                  DateTime BirthDate, DateTime FirstEpisodeDate,
                                  DateTime LastEpisodeDate)
        {
            var Doctor = new Doctor
            {
                DoctorNumber = DoctorNumber,
                DoctorName = DoctorName,
                BirthDate = BirthDate,
                FirstEpisodeDate = FirstEpisodeDate,
                LastEpisodeDate = LastEpisodeDate
            };
            _context.Doctors.Add(Doctor);
            _context.SaveChanges();
        }
        private static void UpdateDoctors(int DoctorId)
        {
            var Doctor = _context.Doctors.Find(DoctorId);
            Doctor.DoctorName += "Kayed";
            _context.SaveChanges();
        }
        private static void DeleteDoctors(int DoctorId)
        {
            var Doctor = _context.Doctors.Find(DoctorId);
            _context.Doctors.Remove(Doctor);
            _context.SaveChanges();
        }
        private static void CreateEnemys(string EnemyName, string EnemyDescription)
        {
            var Enemy = new Enemy { EnemyName = EnemyName, EnemyDescription = EnemyDescription };
            _context.Enemys.Add(Enemy);
            _context.SaveChanges();
        }
        private static void UpdateEnemys(int EnemyId)
        {
            var Enemy = _context.Enemys.Find(EnemyId);
            Enemy.EnemyName += "Kayed";
            _context.SaveChanges();
        }
        private static void DeleteEnemys(int EnemyId)
        {
            var Enemy = _context.Enemys.Find(EnemyId);
            _context.Enemys.Remove(Enemy);
            _context.SaveChanges();
        }
        private static void CreateEpisodes(int SeriesNumber, int EpisodeNumber,
                                   string EpisodeType, string Title,
                                   DateTime EpisodeDate, int AuthorId,
                                   int DoctorId, string Nots)
        {
            var Episode = new Episode
            {
                SeriesNumber = SeriesNumber,
                EpisodeNumber = EpisodeNumber,
                EpisodeType = EpisodeType,
                Title = Title,
                EpisodeDate = EpisodeDate,
                AuthorId = AuthorId,
                DoctorId = DoctorId,
                Nots = Nots
            };
            _context.Episodes.Add(Episode);
            _context.SaveChanges();
        }
        private static void UpdateEpisodes(int EpisodeId)
        {
            var Episode = _context.Episodes.Find(EpisodeId);
            Episode.EpisodeType += "Kayed";
            _context.SaveChanges();
        }
        private static void DeleteEpisodes(int EpisodeId)
        {
            var Episode = _context.Episodes.Find(EpisodeId);
            _context.Episodes.Remove(Episode);
            _context.SaveChanges();
        }

        private static void AddCompanionToEpisode(int EpisodeId, int CompanionId)
        {
            var EpisodeCompanion = new EpisodeCompanion { EpisodeId = EpisodeId, CompanionId = CompanionId };
            _context.Add(EpisodeCompanion);
            _context.SaveChanges();
        }
        private static void AddEnemyToEpisode(int EpisodeId, int EnemyId)
        {
            var EpisodeEnemy = new EpisodeEnemy { EpisodeId = EpisodeId, EnemyId = EnemyId };
            _context.Add(EpisodeEnemy);
            _context.SaveChanges();
        }

        private static List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }
        private static Enemy GetEnemyById(int EnemyId)
        {
            return _context.Enemys.Find(EnemyId);
        }
        private static Companion GetCompanionById(int CompanionId)
        {
            return _context.Companions.Find(CompanionId);
        }

    }
}
