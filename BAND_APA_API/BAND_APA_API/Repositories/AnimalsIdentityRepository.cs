using System.Collections.Generic;
using System.Linq;
using band_apa_api.Data;
using band_apa_api.Entities;

namespace band_apa_api.Repositories
{
    public class AnimalsIdentityRepository : IAnimalsIdentityRepository
    {
        private ApplicationContext _applicationContext;
        public AnimalsIdentityRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }
       
        public List<AnimalsIdentity> FindAll()
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identities.ToList();
        }
        public AnimalsIdentity FindById( int id)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identities.Single(ai => ai.aiID == id);
        }
        public List<AnimalsIdentity> FindBySexe(string sex)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identities.Where(ai => ai.sexe.Trim().ToUpper().Contains(sex.Trim().ToUpper())).ToList();
        }
        public List<AnimalsIdentity> FindByEspece(string espece)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identities.Where(ai => ai.espece.Trim().ToUpper().Contains(espece.Trim().ToUpper())).ToList();
        }
        public List<AnimalsIdentity> FindByRace(string race)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identities.Where(ai => ai.race.Trim().ToUpper().Contains(race.Trim().ToUpper())).ToList();
        }
        public List<AnimalsIdentity> FindByCouleur(string couleur)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identities.Where(ai => ai.couleur.Trim().ToUpper().Contains(couleur.Trim().ToUpper())).ToList();
        }
        public AnimalsIdentity Create(AnimalsIdentity newAnimalsIdentity)
        {
            _applicationContext.Animals_Identities.Add(newAnimalsIdentity);
            _applicationContext.SaveChanges();
            return newAnimalsIdentity;
        }
    }
}
