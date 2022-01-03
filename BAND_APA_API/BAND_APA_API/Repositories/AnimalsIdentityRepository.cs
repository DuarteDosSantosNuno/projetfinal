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
<<<<<<< HEAD
            return _applicationContext.AnimalsIdentities.ToList();
=======
            return _applicationContext.Animals_Identities.ToList();
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
        }
        public AnimalsIdentity FindById( int id)
        {
            //_logger.LogInformation("Info : test");
<<<<<<< HEAD
            return _applicationContext.AnimalsIdentities.Single(ai => ai.aiID == id);
=======
            return _applicationContext.Animals_Identities.Single(ai => ai.aiID == id);
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
        }
        public List<AnimalsIdentity> FindBySexe(string sex)
        {
            //_logger.LogInformation("Info : test");
<<<<<<< HEAD
            return _applicationContext.AnimalsIdentities.Where(ai => ai.sexe.Trim().ToUpper().Contains(sex.Trim().ToUpper())).ToList();
=======
            return _applicationContext.Animals_Identities.Where(ai => ai.sexe.Trim().ToUpper().Contains(sex.Trim().ToUpper())).ToList();
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
        }
        public List<AnimalsIdentity> FindByEspece(string espece)
        {
            //_logger.LogInformation("Info : test");
<<<<<<< HEAD
            return _applicationContext.AnimalsIdentities.Where(ai => ai.espece.Trim().ToUpper().Contains(espece.Trim().ToUpper())).ToList();
=======
            return _applicationContext.Animals_Identities.Where(ai => ai.espece.Trim().ToUpper().Contains(espece.Trim().ToUpper())).ToList();
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
        }
        public List<AnimalsIdentity> FindByRace(string race)
        {
            //_logger.LogInformation("Info : test");
<<<<<<< HEAD
            return _applicationContext.AnimalsIdentities.Where(ai => ai.race.Trim().ToUpper().Contains(race.Trim().ToUpper())).ToList();
=======
            return _applicationContext.Animals_Identities.Where(ai => ai.race.Trim().ToUpper().Contains(race.Trim().ToUpper())).ToList();
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
        }
        public List<AnimalsIdentity> FindByCouleur(string couleur)
        {
            //_logger.LogInformation("Info : test");
<<<<<<< HEAD
            return _applicationContext.AnimalsIdentities.Where(ai => ai.couleur.Trim().ToUpper().Contains(couleur.Trim().ToUpper())).ToList();
        }
        public AnimalsIdentity Create(AnimalsIdentity newAnimalsIdentity)
        {
            _applicationContext.AnimalsIdentities.Add(newAnimalsIdentity);
=======
            return _applicationContext.Animals_Identities.Where(ai => ai.couleur.Trim().ToUpper().Contains(couleur.Trim().ToUpper())).ToList();
        }
        public AnimalsIdentity Create(AnimalsIdentity newAnimalsIdentity)
        {
            _applicationContext.Animals_Identities.Add(newAnimalsIdentity);
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
            _applicationContext.SaveChanges();
            return newAnimalsIdentity;
        }
        public bool DeleteById(int id)
        {
<<<<<<< HEAD
            AnimalsIdentity animalsIdentity = _applicationContext.AnimalsIdentities.Single(ai => ai.aiID == id);
            if (animalsIdentity == null)
                return false;
            _applicationContext.AnimalsIdentities.Remove(animalsIdentity);
=======
            AnimalsIdentity animalsIdentity = _applicationContext.Animals_Identities.Single(ai => ai.aiID == id);
            if (animalsIdentity == null)
                return false;
            _applicationContext.Animals_Identities.Remove(animalsIdentity);
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
            _applicationContext.SaveChanges();
            return true;
        }
        public bool Update(AnimalsIdentity newAnimalsIdentity)
        {
<<<<<<< HEAD
            AnimalsIdentity animalsIdentity = _applicationContext.AnimalsIdentities.Single(ai => ai.aiID == newAnimalsIdentity.aiID);
=======
            AnimalsIdentity animalsIdentity = _applicationContext.Animals_Identities.Single(ai => ai.aiID == newAnimalsIdentity.aiID);
>>>>>>> d8e09df071b52ab39f2185d602cc3bf6cafa41e7
            if (animalsIdentity == null)
                return false;
            animalsIdentity.dateEntree = newAnimalsIdentity.dateEntree;
            animalsIdentity.nom = newAnimalsIdentity.nom;
            animalsIdentity.espece = newAnimalsIdentity.espece;
            animalsIdentity.race = newAnimalsIdentity.race;
            animalsIdentity.sexe = newAnimalsIdentity.sexe;
            animalsIdentity.couleur = newAnimalsIdentity.couleur;
            animalsIdentity.age = newAnimalsIdentity.age;
            animalsIdentity.comments = newAnimalsIdentity.comments;
            animalsIdentity.photo = newAnimalsIdentity.photo;
            _applicationContext.SaveChanges();
            return true;
        }
    }
}
