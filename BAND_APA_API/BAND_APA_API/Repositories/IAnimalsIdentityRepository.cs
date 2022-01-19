using band_apa_api.Entities;
using System.Collections.Generic;

namespace band_apa_api.Repositories
{
    public interface IAnimalsIdentityRepository
    {
        public List<AnimalsIdentity> FindAll();
        public AnimalsIdentity FindById (int id);
        public List<AnimalsIdentity> FindFilters(Dictionary<string,List<string>> filtres);
        public List<AnimalsIdentity> FindBySexe (string sex);
        public List<AnimalsIdentity> FindByEspece(string espece);
        public List<AnimalsIdentity> FindByRace(string race);
        public List<AnimalsIdentity> FindByCouleur(string couleur);
        public AnimalsIdentity Create(AnimalsIdentity newAnimalsIdentity);
        public bool DeleteById(int id);
        public bool Update(AnimalsIdentity newAnimalsIdentity);
    }
}
