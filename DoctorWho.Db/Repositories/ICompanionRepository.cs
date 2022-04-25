using DoctorWho.Db.Entities;
using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface ICompanionRepository
    {
        void CreateCompanions(string CompanionName, string WhoPlayed);
        void DeleteCompanions(int CompanionId);
        List<fnCompanions> fnCompanions();
        Companion GetCompanionById(int CompanionId);
        void UpdateCompanions(int CompanionId);
    }
}