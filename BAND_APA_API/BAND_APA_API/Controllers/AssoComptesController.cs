using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using band_apa_api.Repositories;
using band_apa_api.Entities;

namespace band_apa_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AssoComptesController : Controller

    {
        private readonly ILogger<AssoComptesController> _logger;
        private readonly IAssoCompteRepository _assoCompteRepository;
        public AssoComptesController(IAssoCompteRepository assoCompteRepository, ILogger<AssoComptesController> logger)
        {
            _logger = logger;
            _assoCompteRepository = assoCompteRepository;
        }
        [HttpGet("{id:int}")]
        public AssoCompte GetById(int id)
        {
            return _assoCompteRepository.FindById(id);
        }
        [HttpPost()]
        public IActionResult CreatedActionResult([FromBody] AssoCompte newAssoCompte)
        {
            newAssoCompte = _assoCompteRepository.Create(newAssoCompte);
            return CreatedAtAction(nameof(GetById), new { id = newAssoCompte.userID }, newAssoCompte);
        }
        [HttpPut()]
        public IActionResult Modify([FromBody] AssoCompte ac)
        {
            OkObjectResult modifyResult = new OkObjectResult(_assoCompteRepository.Update(ac));
            return modifyResult;
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            OkObjectResult deleteResult = new OkObjectResult(_assoCompteRepository.DeleteById(id));
            return deleteResult;
        }
    }
}
