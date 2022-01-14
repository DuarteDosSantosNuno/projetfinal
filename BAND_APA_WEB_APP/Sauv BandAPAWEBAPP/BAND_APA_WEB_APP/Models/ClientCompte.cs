using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAND_APA_WEB_APP
{
    public class ClientCompte
    {
        public int clientID { get; set; }
        public string titre { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime birthDate { get; set; }
        public string eMail { get; set; }
        public string adresse1 { get; set; }
        public string adresse2 { get; set; }
        public int codePostal { get; set; }
        public string ville { get; set; }
        public string telephone { get; set; }
        public string connectIdent { get; set; }
        public string connectPwd { get; set; }
    }
}
