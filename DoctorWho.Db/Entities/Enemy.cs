using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class Enemy
    {
        [Key]
        public int EnemyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string EnemyName { get; set; }
        [MaxLength(200)]
        public string EnemyDescription { get; set; }
        public List<EpisodeEnemy> EpisodeEnemys { get; set; }

    }
}
