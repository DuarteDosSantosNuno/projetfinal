﻿using System.Collections.Generic;
using System.Linq;
using band_apa_api.Data;
using band_apa_api.Entities;

namespace band_apa_api.Repositories
{
    public class ClientCompteRepository : IClientCompteRepository
    {
        private ApplicationContext _applicationContext;
        public ClientCompteRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }
        public ClientCompte FindById(int id)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.ClientComptes.Single(ai => ai.clientID == id);
        }
        public ClientCompte FindByIdent(string connectIdent, string connectPwd)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.ClientComptes.Single(cc => cc.connectIdent == connectIdent && cc.connectPwd == connectPwd);
        }
        public ClientCompte Create(ClientCompte newClientCompte)
        {
            _applicationContext.ClientComptes.Add(newClientCompte);
            _applicationContext.SaveChanges();
            return newClientCompte;
        }
        public bool Update(ClientCompte newClientCompte)
        {
            ClientCompte clientCompte = _applicationContext.ClientComptes.Single(cc => cc.clientID == newClientCompte.clientID);
            if (clientCompte == null)
                return false;
            clientCompte.titre = newClientCompte.titre;
            clientCompte.nom = newClientCompte.nom;
            clientCompte.prenom = newClientCompte.prenom;
            clientCompte.birthDate = newClientCompte.birthDate;
            clientCompte.eMail = newClientCompte.eMail;
            clientCompte.adresse1 = newClientCompte.adresse1;
            clientCompte.adresse2 = newClientCompte.adresse2;
            clientCompte.codePostal = newClientCompte.codePostal;
            clientCompte.ville = newClientCompte.ville;
            clientCompte.telephone = newClientCompte.telephone;
            clientCompte.connectIdent = newClientCompte.connectIdent;
            clientCompte.connectPwd = newClientCompte.connectPwd;
            _applicationContext.SaveChanges();
            return true;
        }
        public bool DeleteByIdent(string connectIdent, string connectPwd)
        {
            ClientCompte clientCompte = _applicationContext.ClientComptes.Single(cc => cc.connectIdent == connectIdent && cc.connectPwd==connectPwd);
            if (clientCompte == null)
                return false;
            _applicationContext.ClientComptes.Remove(clientCompte);
            _applicationContext.SaveChanges();
            return true;
        }

    }
}