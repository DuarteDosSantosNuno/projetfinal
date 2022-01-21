using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace band_apa_api.Entities
{
    [Table("AnimalsIdentity")]
    public class CreateAnimalsIdentity
    {
        //public int aiID { get; set; }
        //[Required]
        //[Timestamp]
        public DateTime dateEntree { get; set; }
        [Required]
        [StringLength(75)]
        public string nom { get; set; }
        [Required]
        [StringLength(50)]
        public string espece { get; set; }
        [Required]
        [StringLength(75)]
        public string race { get; set; }
        [StringLength(7)]
        public string sexe { get; set; }
        [Required]
        [StringLength(100)]
        public string couleur { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        [StringLength(1000)]
        public string comments { get; set; }
        [Required]
        [StringLength(50)]
        public string photo { get; set; }

    }
}