using System;
using System.ComponentModel.DataAnnotations;

namespace band_apa_api.Entities
{
    public class CreateClientCompte
    {
        [StringLength(4)]
        public string titre { get; set; }
        [Required]
        [StringLength(75)]
        public string nom { get; set; }
        [Required]
        [StringLength(75)]
        public string prenom { get; set; }
        //[Required]
        //[Timestamp]
        public DateTime birthDate { get; set; }
        [Required]
        [StringLength(160)]
        [EmailAddress]
        public string eMail { get; set; }
        [Required]
        [StringLength(200)]
        public string adresse1 { get; set; }
        [StringLength(200)]
        public string adresse2 { get; set; }
        [Required]
        public int codePostal { get; set; }
        [Required]
        [StringLength(75)]
        public string ville { get; set; }
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
