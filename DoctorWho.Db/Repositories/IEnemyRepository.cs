using DoctorWho.Db.Entities;
using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface IEnemyRepository
    {
        void CreateEnemys(string EnemyName, string EnemyDescription);
        void DeleteEnemys(int EnemyId);
        List<fnEnemies> fnEnemies();
        Enemy GetEnemyById(int EnemyId);
        void UpdateEnemys(int EnemyId);
    }
}