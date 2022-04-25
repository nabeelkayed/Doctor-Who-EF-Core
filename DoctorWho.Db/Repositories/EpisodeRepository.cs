using DoctorWho.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void CreateEpisodes(int SeriesNumber, int EpisodeNumber,
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
        public void UpdateEpisodes(int EpisodeId)
        {
            var Episode = _context.Episodes.Find(EpisodeId);
            Episode.EpisodeType += "Kayed";
            _context.SaveChanges();
        }
        public void DeleteEpisodes(int EpisodeId)
        {
            var Episode = _context.Episodes.Find(EpisodeId);
            _context.Episodes.Remove(Episode);
            _context.SaveChanges();
        }

        public List<viewEpisodes> viewEpisodes()
        {
            return _context.viewEpisodes.FromSqlRaw("select * from viewEpisodes;").ToList();
        }
        public List<spSummariseEpisodes> spSummariseEpisodes()
        {
            return _context.spSummariseEpisodes.FromSqlRaw("EXEC spSummariseEpisodes;").ToList();
        }
    }
}
