using DoctorWho.Db;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        private static ICompanionRepository CompanionRepository = new CompanionRepository(_context);
        private static IEnemyRepository EnemyRepository = new EnemyRepository(_context);
        private static IDoctorRepository DoctorRepository = new DoctorRepository(_context);
        private static IAuthorRepository AuthorRepository = new AuthorRepository(_context);
        private static IEpisodeRepository EpisodeRepository = new EpisodeRepository(_context);
        private static IEpisodeEnemyRepository EpisodeEnemyRepository = new EpisodeEnemyRepository(_context);
        private static IEpisodeCompanionRepository EpisodeCompanionRepository = new EpisodeCompanionRepository(_context);


        static void Main(string[] args)
        {
            var Companions = CompanionRepository.fnCompanions();
            var Enemies = EnemyRepository.fnEnemies();
            var Episodes = EpisodeRepository.viewEpisodes();

            var Doctors = DoctorRepository.GetAllDoctors();
            var enemy = EnemyRepository.GetEnemyById(1);
            var companion = CompanionRepository.GetCompanionById(1);

        }
    }
}
