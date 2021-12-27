using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAND_APA_API.Entities
{
    [Table("Client_Compte")]
    public class Client_Compte
    {
        [Required]
        public int client_ID { get; set; }
        [StringLength(4)]
        public string titre { get; set; }
        [Required]
        [StringLength(75)]
        public string nom { get; set; }
        [Required]
        [StringLength(75)]
        public string prenom { get; set; }
        [Required]
        [Timestamp]
        public DateTime birth_date { get; set; }
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
        public int code_postal { get; set; }
        [Required]
        [StringLength(75)]
        public string ville { get; set; }
        [Required]
        [StringLength(13)]
        [Phone]
        public string telephone { get; set; }
        [Required]
        [StringLength(30)]
        public string connect_id { get; set; }
        [Required]
        [StringLength(36)]
        public string connect_pwd { get; set; }
    }
}
