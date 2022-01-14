using BAND_APA_WEB_APP.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAND_APA_WEB_APP
{
   public class Demand
    {
        public int demandID { get; set; }
        public bool adoption { get; set; }
        public bool depot { get; set; }
        public string statusSocial { get; set; }
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
        public int AssoCompteID { get; set; }
        public AssoCompte AssoCompte { get; set; }
        public int ClientCompteID { get; set; }
        public ClientCompte Client_compte { get; set; }

    }
}
