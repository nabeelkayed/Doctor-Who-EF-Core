using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class Episode
    {
        [Key]
        public int EpisodeId { get; set; }
        [Required]
        public int SeriesNumber { get; set; }
        [Required]
        public int EpisodeNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string EpisodeType { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int AuthorId { get; set; }
        public int? DoctorId { get; set; }
        [MaxLength(500)]
        public string Nots { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
        public List<EpisodeEnemy> EpisodeEnemys { get; set; }

    }
}
