using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAND_APA_API.Entities
{
    [Table("Demand")]
    public class Demand
    {
        [Required]
        public int demand_ID { get; set; }
        [Required]
        public bool adoption { get; set; }
        [Required]
        public bool depot { get; set; }
        [Required]
        [StringLength(400)]
        public string status_social { get; set; }
        [ForeignKey("Animals_Identity")]
        public int Animals_IdentityID { get; set; }
        [Required]
        public Animals_Identity animals_Identity { get; set; }
        [ForeignKey("Asso_Compte")]
        public int Asso_CompteID { get; set; }
        [Required]
        public Asso_Compte asso_compte { get; set; }
        [ForeignKey("Client_Compte")]
        public int Client_CompteID { get; set; }
        [Required]
        public Client_Compte client_compte { get; set; }

    }
}
