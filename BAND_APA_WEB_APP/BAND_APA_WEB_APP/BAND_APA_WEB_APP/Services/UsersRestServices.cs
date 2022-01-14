using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Net;
using System.Threading.Tasks;
using BAND_APA_WEB_APP.Models;
using BAND_APA_WEB_APP.Controllers;

namespace BAND_APA_WEB_APP.Services
{
    public class UsersRestServices
    {
        private HttpClient _httpClient;
        private ILogger<UsersRestServices> _logger;
        private JsonSerializerOptions serializeOptions;
        private const string urlBase = "https://localhost:44356/api/v1/ClientComptes";

        public JsonNamingPolicy PropertyNamingPolicy { get; private set; }
        public bool WriteIndented { get; private set; }

        public UsersRestServices(HttpClient httpClient, ILogger<UsersRestServices> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
            serializeOptions = new JsonSerializerOptions();
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                WriteIndented = true;
            };
        }
        public async Task<List<User>> FindAll()
        {
            var responseHttpUsersRest = await _httpClient.GetAsync($"{urlBase}/");
            if (responseHttpUsersRest.StatusCode != HttpStatusCode.OK)
                throw new Exception("Liste des comptes clients vide.");
            string responseBody = await responseHttpUsersRest.Content.ReadAsStringAsync();
            List<User> users = JsonSerializer.Deserialize<List<User>>(responseBody, serializeOptions);
            return users;
        }
        public async Task<User> FindByIdent(string connectIdent, string connectPwd)
        {
           /* string json1 = JsonSerializer.Serialize(connectIdent, serializeOptions);
            StringContent httpContent1 = new StringContent(json1, System.Text.Encoding.UTF8, "application/json");
            string json2 = JsonSerializer.Serialize(connectPwd, serializeOptions);
            StringContent httpContent2 = new StringContent(json2, System.Text.Encoding.UTF8, "application/json");*/
            var responseHttpUserRest = await _httpClient.GetAsync($"{urlBase}/{connectIdent}/{connectPwd}");
            if (responseHttpUserRest.StatusCode != HttpStatusCode.OK)
                throw new Exception("Recherche KO!");
            string responseBody = await responseHttpUserRest.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(responseBody, serializeOptions);
            return user;
        }
    }
}
