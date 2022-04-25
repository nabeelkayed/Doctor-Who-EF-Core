using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        public int DoctorNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public List<Episode> Episodes { get; set; }


    }
}
