using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BAND_APA_WEB_APP.Models;
using ProjetFinalWebApp.Services;
using System.Text.Json;
using System.Text;

namespace BAND_APA_WEB_APP.Controllers
{
    [Route("Controller")]
    public class UserController : Controller
    {
        public const string SEPARATOR = ";";
        public const string PATH_FILE = "../../User.csv";
        private const string urlBase = "https://localhost:44356/api/v1/ClientComptes";
        HttpClient newHttpClient = new HttpClient();
        private CreateAccountRestServices _createAccountRestService;

        public UserController()
        {
            _createAccountRestService = new CreateAccountRestServices(newHttpClient);
        }
        [HttpPost]
        [Route("CreateAccount")]
        public async Task<ActionResult> CreateAccount(User newClientCompte)
        {
            try
            {
                User temp = await _createAccountRestService.Create(newClientCompte);

                return View("~/Views/User/CreateSuccess.cshtml");
            }
            catch
            {
                 return View();
                
            }
        }
        [HttpGet("", Name = "page_index_users")]
        public async Task<List<User>> FindAll()
        {
            var client = new HttpClient();
            List<User> users = new List<User>();
            var result = await client.GetAsync($"{urlBase}/");
            if (!result.IsSuccessStatusCode)
                throw new Exception("Liste des comptes clients vide.");
            var content = await result.Content.ReadAsStringAsync();
            users = JsonConvert.DeserializeObject<List<User>>(content);
            return users;
        }

        [HttpGet]
        [Route("UserConnection")]
        public async Task<ActionResult> UserConnection(string connectIdent, string connectPwd)
        {
            var client = new HttpClient();
            User user = new User();
            var result = await client.GetAsync($"{urlBase}/{connectIdent}/{connectPwd}");
            if (!result.IsSuccessStatusCode)
                throw new Exception("Le compte ou (et) le mot de passe sont éronnés ou inexistant.");
            var content = await result.Content.ReadAsStringAsync();
            user = JsonConvert.DeserializeObject<User>(content);
            StreamWriter sw = null;
            sw = new StreamWriter(PATH_FILE, false);
            string newLine = $"{user.clientID}";
            sw.WriteLine(newLine);
            sw.Close();
            return View(user);
        }
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("CreateAccount")]
        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpGet]
        [Route("Profil")]
        public async Task<ActionResult> Profil()
        {
            var result = await FindById();
            return View(result);
        }

        public async Task<User> FindById()
        {
            var client = new HttpClient();
            User user = new User();
           
            StreamReader sw = null;
            sw = new StreamReader(PATH_FILE, false);
            string id = sw.ReadLine();//$"{user.clientID}";
            sw.Close();

            var result = await client.GetAsync($"{urlBase}/{id}");
            var content = await result.Content.ReadAsStringAsync();
            user = JsonConvert.DeserializeObject<User>(content);

            return user;
        }

        public async Task<ActionResult> Update(User userUpdated)
        {
            var client = new HttpClient();
            User user = new User();

            var json = JsonConvert.SerializeObject(userUpdated);
            var result = await client.PutAsync($"{urlBase}", new StringContent(json, Encoding.UTF8, "application/json"));
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<User>(content);
            }

            return View("~/Views/User/Profil.cshtml");
        }

        // POST: UserController/Create
        /*[HttpPost]
        [Route("Create")]
        public async Task<ActionResult> CreateAsync(User newClientCompte)
        {
            try
            {
                User temp = await _createAccountRestService.Create(newClientCompte);

                return View("~/Views/User/CreateSuccess.cshtml");
            }
            catch
            {
                return View();

            }
        }*/


    }
}
