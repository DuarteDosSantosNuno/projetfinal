using BAND_APA_WEB_APP.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace ProjetFinalWebApp.Services
{
    public class CreateAccountRestServices
    {
        private HttpClient _httpClient;
        private JsonSerializerOptions serializeOptions;
        private const string urlBase = "https://localhost:44356/api/v1/ClientComptes/CreateAccount";
        public CreateAccountRestServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
            serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<User> Create(User newCompte)
        {
            string json = JsonSerializer.Serialize(newCompte, serializeOptions);

            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var responseHttpClientRest = await _httpClient.PostAsync($"{urlBase}", httpContent);

            if (responseHttpClientRest.StatusCode != HttpStatusCode.Created)
            {
                throw new Exception("Creation impossible : erreur technique");
            }

            var urlVersDetailCompte = responseHttpClientRest.Headers.Location;

            responseHttpClientRest = await _httpClient.GetAsync(urlVersDetailCompte.ToString());

            if (responseHttpClientRest.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("recuperation  impossible : erreur technique");
            }
            string responseBody = await responseHttpClientRest.Content.ReadAsStringAsync();
            User createClientCompte = JsonSerializer.Deserialize<User>(responseBody, serializeOptions);

            return createClientCompte;
        }
    }
}