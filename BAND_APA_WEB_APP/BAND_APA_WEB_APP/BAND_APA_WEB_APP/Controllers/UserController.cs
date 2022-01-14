using BAND_APA_WEB_APP.Models;
using BAND_APA_WEB_APP.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BAND_APA_WEB_APP.Controllers
{
    [Route("Controller")]
    public class UserController : Controller
    {
        //private static string base_url = "https://localhost:44356";
        private readonly ILogger<UserController> _logger;
        private UsersRestServices _usersRestServices;
        public UserController(UsersRestServices usersRestServices, ILogger<UserController> logger)
        {
            _usersRestServices = usersRestServices;
            _logger = logger;
        }

        // GET: UserController
        /*public async Task<List<User>> GetUser()
        {
            var client = new HttpClient();
            var result = await client.GetAsync($"{base_url}/api/v1/ClientComptes");
            List<User> response = new List<User>();

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<List<User>>(content);
            }
            return response;
        }*/
        [HttpGet("", Name = "page_index_users")]
        public async Task<ActionResult> FindTous()
        {
            _logger.LogInformation("Récupération de la liste des comptes des clients");
            List<User> users = await _usersRestServices.FindAll();
            this.ViewData["users"] = users;
            return View(users);
        }
        /* public async Task<User> GetUserConnection(string connectIdent, string connectPwd)
         {
             var client = new HttpClient();
             var user = await _usersRestServices.FindByIdent(connectIdent, connectPwd);
            *//* User response = new User();
             if (result.IsSuccessStatusCode)
             {
                 var content = await result.Content.ReadAsStringAsync();
                 response = JsonConvert.DeserializeObject<User>(content);
             }*//*
             return user;
         }*/
        [HttpGet]
        [Route("UserConnection")]
        public async Task<ActionResult> UserConnection(string connectIdent, string connectPwd)
        {
            _logger.LogInformation("Récupération de l'utilisateur");
            User user = await _usersRestServices.FindByIdent(connectIdent, connectPwd);
            return View(user);
        }
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }
        // GET: UserController/Details/5
        /*public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }*/

        // POST: UserController/Create
        [HttpPost]
        [Route("Create")]
        public ActionResult Create(IFormCollection collection)
        {
            /*try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }*/
            return View();
        }

        /*// GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
        }*/
    }
}
