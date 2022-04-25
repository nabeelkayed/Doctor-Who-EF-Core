using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : IEnemyRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void CreateEnemys(string EnemyName, string EnemyDescription)
        {
            var Enemy = new Enemy { EnemyName = EnemyName, EnemyDescription = EnemyDescription };
            _context.Enemys.Add(Enemy);
            _context.SaveChanges();
        }
        public void UpdateEnemys(int EnemyId)
        {
            var Enemy = _context.Enemys.Find(EnemyId);
            Enemy.EnemyName += "Kayed";
            _context.SaveChanges();
        }
        public void DeleteEnemys(int EnemyId)
        {
            var Enemy = _context.Enemys.Find(EnemyId);
            _context.Enemys.Remove(Enemy);
            _context.SaveChanges();
        }
        public Enemy GetEnemyById(int EnemyId)
        {
            return _context.Enemys.Find(EnemyId);
        }
        public List<fnEnemies> fnEnemies()
        {
            return _context.fnEnemies.FromSqlRaw("SELECT * from dbo.fnEnemies(1);").ToList();
        }
    }
}
