using BAND_APA_WEB_APP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjetFinalWebApp.Controllers
{
    public class AnimalController : Controller
    {
        private static string base_url = "https://localhost:44356";
        

        public async Task<List<Animal>> GetAnimal()
        {
            var client = new HttpClient();
            var result = await client.GetAsync($"{base_url}/api/v1/AnimalsIdentities");
            List<Animal> response = new List<Animal>();

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<List<Animal>>(content);
            }
            return response;
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

        // GET: AnimalController
        public async Task<ActionResult> Index()
        {
            List<Animal> animals = new List<Animal>();
            animals = await GetAnimal();

            return View(animals);
        }

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
    }
}
