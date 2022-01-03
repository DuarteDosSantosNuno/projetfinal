using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace band_apa_api.Entities
{
    [Table("AssoCompte")]
    public class AssoCompte
    {
        [Required]
        [Key]
        public int userID { get; set; }
        [Required]
        [StringLength(50)]
        public string role { get; set;}
        [StringLength(4)]
        public string titre { get; set; }
        [Required]
        [StringLength(75)]
        public string nom { get; set; }
        [Required]
        [StringLength(75)]
        public string prenom { get; set; }
        [Required]
<<<<<<< HEAD:BAND_APA_API/BAND_APA_API/Entities/AssoCompte.cs
        //[Timestamp]
=======
        [Timestamp]
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7:BAND_APA_API/BAND_APA_API/Entities/Asso_Compte.cs
        public DateTime birthDate { get; set; }
        [Required]
        [StringLength(160)]
        [EmailAddress]
        public string eMail { get; set; }
        [Required]
        [StringLength(13)]
        [Phone]
        public string telephone { get; set; }
        [Required]
        [StringLength(30)]
        public string connectIdent { get; set; }
        [Required]
        [StringLength(36)]
        public string connectPwd { get; set; }
    }
}
