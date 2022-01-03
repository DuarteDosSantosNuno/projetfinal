using band_apa_api.Entities;
using System.Collections.Generic;

namespace band_apa_api.Repositories
{
    public interface IAssoCompteRepository
    {
        public AssoCompte FindById(int id);
        public AssoCompte Create(AssoCompte newAssoCompte);
        public bool Update(AssoCompte newAssoCompte);
        public bool DeleteById(int id);
    }
}
