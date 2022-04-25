using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class Companion
    {
        [Key]
        public int CompanionId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CompanionName { get; set; }
        [Required]
        [MaxLength(50)]
        public string WhoPlayed { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }

    }
}
