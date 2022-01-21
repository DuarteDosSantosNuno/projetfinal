using BAND_APA_WEB_APP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetFinalWebApp.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjetFinalWebApp.Controllers
{
    public class AnimalController : Controller
    {
        private static string base_url = "https://localhost:44356";
        HttpClient newHttpClient = new HttpClient();
        private CreateAnimalsRestServices _createAnimalsRestService;

        public AnimalController()
        {
            _createAnimalsRestService = new CreateAnimalsRestServices(newHttpClient);
        }

        public async Task<List<Animal>> GetAnimal(Dictionary<string, List<string>> filter = null)
        {
            var client = new HttpClient();
            List<Animal> response = new List<Animal>();

            if (filter["especes"].Count == 0 && filter["races"].Count == 0 && filter["sexes"].Count == 0 && filter["couleurs"].Count == 0)
            {
                var result = await client.GetAsync($"{base_url}/api/v1/AnimalsIdentities");

                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<List<Animal>>(content);
                }

                return response;
            }               
            else
            {
                if (filter["especes"].Count == 0)
                    filter.Remove("especes");
                if (filter["races"].Count == 0)
                    filter.Remove("races");
                if (filter["sexes"].Count == 0)
                    filter.Remove("sexes");
                if (filter["couleurs"].Count == 0)
                    filter.Remove("couleurs");

                var json = JsonConvert.SerializeObject(filter);
                var result = await client.PostAsync($"{base_url}/api/v1/AnimalsIdentities/FindWithFilter", new StringContent(json, Encoding.UTF8, "application/json"));

                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<List<Animal>>(content);
                }

                return response;
            }
        }

        public async Task<Animal> GetAnimalById(int id)
        {
            var client = new HttpClient();
            var result = await client.GetAsync($"{base_url}/api/v1/AnimalsIdentities/{id}");
            Animal response = new Animal();

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<Animal>(content);
            }
            return response;
        }

        //public async Task<List<Animal>> FilterAnimalBySpecie(string espece)
        //{
        //    var client = new HttpClient();
        //    var result = await client.GetAsync($"{base_url}/api/v1/AnimalsIdentities/FindEspece/{espece}");
        //    List<Animal> response = new List<Animal>();

        //    if (result.IsSuccessStatusCode)
        //    {
        //        var content = await result.Content.ReadAsStringAsync();
        //        response = JsonConvert.DeserializeObject<List<Animal>>(content);
        //    }

        //    return response;
        //}

        public async Task<List<Animal>> GetFiltersSelectors()
        {
            var client = new HttpClient();
            List<Animal> response = new List<Animal>();
            var result = await client.GetAsync($"{base_url}/api/v1/AnimalsIdentities");

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<List<Animal>>(content);
            }

            return response;
        }


        public async Task<ActionResult> Index(List<string> especes , List<string> races, List<string> sexes, List<string> couleurs)
        {
            List<Animal> animals = new List<Animal>();
            List<Animal> filtersSelectors = new List<Animal>();
            Dictionary<string, List<string>> filters = new Dictionary<string, List<string>>();
            
            filters.Add("especes", especes);
            filters.Add("races", races);
            filters.Add("sexes", sexes);
            filters.Add("couleurs", couleurs);

            animals = await GetAnimal(filters);
            filtersSelectors = await GetFiltersSelectors();

            IndexViewModel indexModel = new IndexViewModel(animals, filtersSelectors);
            return View(indexModel);            
        }

        

        //[HttpPost]
        //public async Task<ActionResult> Index(Dictionary<string, Boolean>? filter = null)
        //{
        //    List<Animal> animals = new List<Animal>();
        //    animals = await GetAnimal(filter);

        //    return View(animals);
        //}

        public async Task<ActionResult> AnimalDetail(int id)
        {
            Animal animal = new Animal();
            animal = await GetAnimalById(id);
            return View(animal);
        }

        // GET: AnimalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnimalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public async Task<ActionResult> Adoption(int id)
        {
            Animal animal = new Animal();
            animal = await GetAnimalById(id);
            return View(animal);
        }
        public async Task<ActionResult> CreateAnimal(CreateAnimal newAnimal)
        {
            try
            {
                Animal temp = await _createAnimalsRestService.CreateAnimal(newAnimal);

                return View("~/Views/Animal/CreateSuccess.cshtml");
            }
            catch
            {
                return View("~/Views/Animal/Create.cshtml");
            }
        }
    }
}
