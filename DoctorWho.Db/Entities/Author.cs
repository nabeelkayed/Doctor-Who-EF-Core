using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorWho.Db
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string AuthorName { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
