using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository : IEpisodeCompanionRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EpisodeCompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddCompanionToEpisode(int EpisodeId, int CompanionId)
        {
            var EpisodeCompanion = new EpisodeCompanion { EpisodeId = EpisodeId, CompanionId = CompanionId };
            _context.Add(EpisodeCompanion);
            _context.SaveChanges();
        }
    }
}
