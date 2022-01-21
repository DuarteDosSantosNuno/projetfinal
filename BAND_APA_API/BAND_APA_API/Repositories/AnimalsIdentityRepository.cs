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
            return _applicationContext.AnimalsIdentities.ToList();
        }
        public AnimalsIdentity FindById( int id)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.AnimalsIdentities.Single(ai => ai.aiID == id);
        }
        public List<AnimalsIdentity> FindBySexe(string sex)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.AnimalsIdentities.Where(ai => ai.sexe.Trim().ToUpper().Contains(sex.Trim().ToUpper())).ToList();
        }
        public List<AnimalsIdentity> FindByEspece(string espece)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.AnimalsIdentities.Where(ai => ai.espece.Trim().ToUpper().Contains(espece.Trim().ToUpper())).ToList();
        }
        public List<AnimalsIdentity> FindByRace(string race)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.AnimalsIdentities.Where(ai => ai.race.Trim().ToUpper().Contains(race.Trim().ToUpper())).ToList();
        }
        public List<AnimalsIdentity> FindByCouleur(string couleur)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.AnimalsIdentities.Where(ai => ai.couleur.Trim().ToUpper().Contains(couleur.Trim().ToUpper())).ToList();
        }
        public AnimalsIdentity Create(CreateAnimalsIdentity newAnimalsIdentity)
        {
            AnimalsIdentity AnimalsIdentity = new AnimalsIdentity();
            AnimalsIdentity.nom = newAnimalsIdentity.nom;
            AnimalsIdentity.sexe = newAnimalsIdentity.sexe;
            AnimalsIdentity.photo = newAnimalsIdentity.photo;
            AnimalsIdentity.couleur = newAnimalsIdentity.couleur;
            AnimalsIdentity.age = newAnimalsIdentity.age;
            AnimalsIdentity.comments = newAnimalsIdentity.comments;
            AnimalsIdentity.espece = newAnimalsIdentity.espece;
            AnimalsIdentity.dateEntree = newAnimalsIdentity.dateEntree;
            AnimalsIdentity.race = newAnimalsIdentity.race;
            _applicationContext.AnimalsIdentities.Add(AnimalsIdentity);
            _applicationContext.SaveChanges();
            return AnimalsIdentity;
        }
        public bool DeleteById(int id)
        {
            AnimalsIdentity animalsIdentity = _applicationContext.AnimalsIdentities.Single(ai => ai.aiID == id);
            if (animalsIdentity == null)
                return false;
            _applicationContext.AnimalsIdentities.Remove(animalsIdentity);
            _applicationContext.SaveChanges();
            return true;
        }
        public bool Update(AnimalsIdentity newAnimalsIdentity)
        {
            AnimalsIdentity animalsIdentity = _applicationContext.AnimalsIdentities.Single(ai => ai.aiID == newAnimalsIdentity.aiID);
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

        public List<AnimalsIdentity> FindFilters(Dictionary<string, List<string>> filtres)
        {

            List<AnimalsIdentity> resultats = _applicationContext.AnimalsIdentities.AsQueryable().Where(a => 
                (!filtres.ContainsKey("races") || (filtres.ContainsKey("races") && filtres["races"].Contains(a.race))) &&
                (!filtres.ContainsKey("especes") || (filtres.ContainsKey("especes") && filtres["especes"].Contains(a.espece)))  &&
                (!filtres.ContainsKey("sexes") || (filtres.ContainsKey("sexes") && filtres["sexes"].Contains(a.sexe))) &&
                (!filtres.ContainsKey("couleurs") || (filtres.ContainsKey("couleurs") && filtres["couleurs"].Contains(a.couleur)))
            ).ToList();
            return resultats;
        }
    }
}
