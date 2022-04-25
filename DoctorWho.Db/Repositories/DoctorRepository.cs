using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorWho.Db.Repositories
{

    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void CreateDoctors(int DoctorNumber, string DoctorName,
                                 DateTime BirthDate, DateTime FirstEpisodeDate,
                                 DateTime LastEpisodeDate)
        {
            var Doctor = new Doctor
            {
                DoctorNumber = DoctorNumber,
                DoctorName = DoctorName,
                BirthDate = BirthDate,
                FirstEpisodeDate = FirstEpisodeDate,
                LastEpisodeDate = LastEpisodeDate
            };
            _context.Doctors.Add(Doctor);
            _context.SaveChanges();
        }
        public void UpdateDoctors(int DoctorId)
        {
            var Doctor = _context.Doctors.Find(DoctorId);
            Doctor.DoctorName += "Kayed";
            _context.SaveChanges();
        }
        public void DeleteDoctors(int DoctorId)
        {
            var Doctor = _context.Doctors.Find(DoctorId);
            _context.Doctors.Remove(Doctor);
            _context.SaveChanges();
        }
        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}
