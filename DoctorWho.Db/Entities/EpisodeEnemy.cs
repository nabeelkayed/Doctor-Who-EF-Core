using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class EpisodeEnemy
    {
        [Key]
        public int EpisodeEnemyId { get; set; }
        [Required]
        public int EpisodeId { get; set; }
        [Required]
        public int EnemyId { get; set; }
        public Episode Episode { get; set; }
        public Enemy Enemy { get; set; }

    }
}
