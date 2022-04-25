using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Db.Entities
{
    public class viewEpisodes
    {
        public int EpisodeId { get; set; }
        public string DoctorName { get; set; }
        public string AuthorName { get; set; }
        public string Companions { get; set; }
        public string Enemies { get; set; }

    }
}
