using DoctorWho.Db.Entities;
using System;
using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface IEpisodeRepository
    {
        void CreateEpisodes(int SeriesNumber, int EpisodeNumber, string EpisodeType, string Title, DateTime EpisodeDate, int AuthorId, int DoctorId, string Nots);
        void DeleteEpisodes(int EpisodeId);
        List<spSummariseEpisodes> spSummariseEpisodes();
        void UpdateEpisodes(int EpisodeId);
        List<viewEpisodes> viewEpisodes();
    }
}