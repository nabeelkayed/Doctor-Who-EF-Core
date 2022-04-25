using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository : IEpisodeEnemyRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EpisodeEnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddEnemyToEpisode(int EpisodeId, int EnemyId)
        {
            var EpisodeEnemy = new EpisodeEnemy { EpisodeId = EpisodeId, EnemyId = EnemyId };
            _context.Add(EpisodeEnemy);
            _context.SaveChanges();
        }
    }
}
