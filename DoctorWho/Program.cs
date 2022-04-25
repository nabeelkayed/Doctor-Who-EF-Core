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
    }
}
