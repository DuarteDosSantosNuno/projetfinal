using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using band_apa_api.Repositories;
using band_apa_api.Entities;

namespace band_apa_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientComptesController : Controller

    {
        private readonly ILogger<ClientComptesController> _logger;
        private readonly IClientCompteRepository _clientCompteRepository;
        public ClientComptesController(IClientCompteRepository clientCompteRepository, ILogger<ClientComptesController> logger)
        {
            _logger = logger;
            _clientCompteRepository = clientCompteRepository;
        }
        [HttpGet("{id:int}")]
        public ClientCompte GetById(int id)
        {
            return _clientCompteRepository.FindById(id);
        }
        [HttpGet("{connectIdent}/{connectPwd}")]
        public ClientCompte GetByIdent( string connectIdent, string connectPwd)
        {
            return _clientCompteRepository.FindByIdent(connectIdent, connectPwd);
        }
        [HttpPost()]
        public IActionResult CreatedActionResult([FromBody] ClientCompte newClientCompte)
        {
            newClientCompte = _clientCompteRepository.Create(newClientCompte);
            return CreatedAtAction(nameof(GetById), new { id = newClientCompte.clientID }, newClientCompte);
        }
        [HttpPut()]
        public IActionResult Modify([FromBody] ClientCompte cl)
        {
            OkObjectResult modifyResult = new OkObjectResult(_clientCompteRepository.Update(cl));
            return modifyResult;
        }
        [HttpDelete("{connectIdent}/{connectPwd}")]
        public IActionResult DeleteByIdent( string connectIdent, string connectPwd)
        {
            OkObjectResult deleteResult = new OkObjectResult(_clientCompteRepository.DeleteByIdent(connectIdent, connectPwd));
            return deleteResult;
        }
       [HttpGet("")]
        public IActionResult GetAll()
        {
            _logger.LogDebug("Appel recu de ClientComptesController.GetAll");
            List<ClientCompte> cc = _clientCompteRepository.FindAll();
            _logger.LogDebug(cc.ToString());
            if (cc == null)
                return NotFound();
            else
                return Ok(cc);
        }
    }
}
