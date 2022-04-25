namespace DoctorWho.Db.Repositories
{
    public interface IEpisodeCompanionRepository
    {
        void AddCompanionToEpisode(int EpisodeId, int CompanionId);
    }
}