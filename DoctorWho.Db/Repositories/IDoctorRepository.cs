using System;
using System.Collections.Generic;

namespace DoctorWho.Db.Repositories
{
    public interface IDoctorRepository
    {
        void CreateDoctors(int DoctorNumber, string DoctorName, DateTime BirthDate, DateTime FirstEpisodeDate, DateTime LastEpisodeDate);
        void DeleteDoctors(int DoctorId);
        List<Doctor> GetAllDoctors();
        void UpdateDoctors(int DoctorId);
    }
}