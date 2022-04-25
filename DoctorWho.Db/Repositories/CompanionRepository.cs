using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : ICompanionRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void CreateCompanions(string CompanionName, string WhoPlayed)
        {
            var Companion = new Companion { CompanionName = CompanionName, WhoPlayed = WhoPlayed };
            _context.Companions.Add(Companion);
            _context.SaveChanges();
        }
        public void UpdateCompanions(int CompanionId)
        {
            var Companion = _context.Companions.Find(CompanionId);
            Companion.CompanionName += "Kayed";
            _context.SaveChanges();
        }
        public void DeleteCompanions(int CompanionId)
        {
            var Companion = _context.Companions.Find(CompanionId);
            _context.Companions.Remove(Companion);
            _context.SaveChanges();
        }
        public Companion GetCompanionById(int CompanionId)
        {
            return _context.Companions.Find(CompanionId);
        }

        public List<fnCompanions> fnCompanions()
        {
            return _context.fnCompanions.FromSqlRaw("SELECT * from dbo.fnCompanions(1);").ToList();
        }
    }
}
