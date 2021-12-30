using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace band_apa_api.Entities
{
    [Table("Demand")]
    public class Demand
    {
        [Required]
        [Key]
        public int demandID { get; set; }
        [Required]
        public bool adoption { get; set; }
        [Required]
        public bool depot { get; set; }
        [Required]
        [StringLength(400)]
        public string statusSocial { get; set; }
        [ForeignKey("AnimalsIdentity")]
        public int AnimalsIdentityID { get; set; }
        //[Required]
        public AnimalsIdentity animalsIdentity { get; set; }
        [ForeignKey("AssoCompte")]
        public int AssoCompteID { get; set; }
        //[Required]
        public AssoCompte assoCompte { get; set; }
        [ForeignKey("ClientCompte")]
        public int ClientCompteID { get; set; }
        //[Required]
        public ClientCompte client_compte { get; set; }

    }
}
