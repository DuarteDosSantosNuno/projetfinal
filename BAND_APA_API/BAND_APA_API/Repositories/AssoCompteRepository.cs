using System.Collections.Generic;
using System.Linq;
using band_apa_api.Data;
using band_apa_api.Entities;

namespace band_apa_api.Repositories
{
    public class AssoCompteRepository : IAssoCompteRepository
    {
        private ApplicationContext _applicationContext;
        public AssoCompteRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }
        public AssoCompte FindById(int id)
        {
            return _applicationContext.AssoComptes.Single(ac => ac.userID == id);
        }
        public AssoCompte Create(AssoCompte newAssoCompte)
        {
            _applicationContext.AssoComptes.Add(newAssoCompte);
            _applicationContext.SaveChanges();
            return newAssoCompte;
        }
        public bool Update(AssoCompte newAssoCompte)
        {
            AssoCompte assoCompte = _applicationContext.AssoComptes.Single(ai => ai.userID == newAssoCompte.userID);
            if (assoCompte == null)
                return false;
            assoCompte.role = newAssoCompte.role;
            assoCompte.titre = newAssoCompte.titre;
            assoCompte.nom = newAssoCompte.nom;
            assoCompte.prenom = newAssoCompte.prenom;
            assoCompte.birthDate = newAssoCompte.birthDate;
            assoCompte.eMail = newAssoCompte.eMail;
            assoCompte.telephone = newAssoCompte.telephone;
            assoCompte.connectIdent = newAssoCompte.connectIdent;
            assoCompte.connectPwd = newAssoCompte.connectPwd;
            _applicationContext.SaveChanges();
            return true;
        }
        public bool DeleteById(int id)
        {
            AssoCompte assoCompte = _applicationContext.AssoComptes.Single(ac => ac.userID == id);
            if (assoCompte == null)
                return false;
            _applicationContext.AssoComptes.Remove(assoCompte);
            _applicationContext.SaveChanges();
            return true;
        }
    }
}
