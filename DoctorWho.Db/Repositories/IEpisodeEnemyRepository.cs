namespace DoctorWho.Db.Repositories
{
    public interface IEpisodeEnemyRepository
    {
        void AddEnemyToEpisode(int EpisodeId, int EnemyId);
    }
}