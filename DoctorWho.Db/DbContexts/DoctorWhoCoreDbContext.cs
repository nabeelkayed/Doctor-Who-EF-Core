using Microsoft.EntityFrameworkCore;
using System;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = DESKTOP-957A0UD\\SQLEXPRESS; User id = sa; password=nabeel; Initial Catalog = DoctorWhoCore;");
        }
    }
}
