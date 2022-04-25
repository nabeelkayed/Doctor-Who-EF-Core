using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class EpisodeCompanion
    {
        [Key]
        public int EpisodeCompanionId { get; set; }
        [Required]
        public int EpisodeId { get; set; }
        [Required]
        public int CompanionId { get; set; }
        public Episode Episode { get; set; }
        public Companion Companion { get; set; }



    }
}
