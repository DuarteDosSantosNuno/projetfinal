using band_apa_api.Entities;
using System.Collections.Generic;

namespace band_apa_api.Repositories
{
    public interface IClientCompteRepository
    {
        public ClientCompte FindById(int id);
        public ClientCompte FindByIdent(string connectIdent, string connectPwd);
        public ClientCompte Create(ClientCompte newClientCompte);
        public bool Update(ClientCompte newClientCompte);
        public bool DeleteByIdent(string connectIdent, string connectPwd);
    }
}
