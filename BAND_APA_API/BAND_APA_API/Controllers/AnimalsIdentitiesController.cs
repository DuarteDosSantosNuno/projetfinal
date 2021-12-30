using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using band_apa_api.Repositories;
using band_apa_api.Entities;

namespace band_apa_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AnimalsIdentitiesController : Controller
    {
        private readonly ILogger<AnimalsIdentitiesController> _logger;
        private readonly IAnimalsIdentityRepository _animalsIdentityRepository;
        public AnimalsIdentitiesController(IAnimalsIdentityRepository animalsIdentityRepository, ILogger<AnimalsIdentitiesController> logger)
        {
            _logger = logger;
            _animalsIdentityRepository = animalsIdentityRepository;
        }
        // GET: Animals_IdentityControllers
        [HttpGet("")]
        public IActionResult GetAll()
        {
            _logger.LogDebug("Appel recu de AnimalsIdentitiesController.GetAll");
            List<AnimalsIdentity> ai = _animalsIdentityRepository.FindAll();
            _logger.LogDebug(ai.ToString());
            if (ai == null)
                return NotFound();
            else
                return Ok(ai);
        }
        [HttpGet("{id:int}")]
        public AnimalsIdentity GetById(int id)
        {
            return _animalsIdentityRepository.FindById(id);
        }
        [HttpGet("FindSexe/{sex}")]
        public List<AnimalsIdentity> GetBySexe([FromRoute] string sex)
        {
            return _animalsIdentityRepository.FindBySexe(sex);
        }
        [HttpGet("FindEspece/{espece}")]
        public List<AnimalsIdentity> GetByEspece([FromRoute] string espece)
        {
            return _animalsIdentityRepository.FindByEspece(espece);
        }
        [HttpGet("FindRace/{race}")]
        public List<AnimalsIdentity> GetByRace([FromRoute] string race)
        {
            return _animalsIdentityRepository.FindByRace(race);
        }
        [HttpGet("FindCouleur/{couleur}")]
        public List<AnimalsIdentity> GetByCouleur([FromRoute] string couleur)
        {
            return _animalsIdentityRepository.FindByCouleur(couleur);
        }
        [HttpPost()]
        public IActionResult CreatedActionResult([FromBody] AnimalsIdentity newAnimalsIdentity)
        {
            newAnimalsIdentity = _animalsIdentityRepository.Create(newAnimalsIdentity);
            return CreatedAtAction(nameof(GetById), new { id = newAnimalsIdentity.aiID }, newAnimalsIdentity);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            OkObjectResult deleteResult = new OkObjectResult(_animalsIdentityRepository.DeleteById(id));
            return deleteResult;
        }
        [HttpPut()]
        public IActionResult Modify([FromBody] AnimalsIdentity ai)
        {
            OkObjectResult modifyResult = new OkObjectResult(_animalsIdentityRepository.Update(ai));
            return modifyResult;
        }
        // GET: Animals_IdentityControllers/Details/5
        /* public ActionResult Details(int id)
         {
             return View();
         }

         // GET: Animals_IdentityControllers/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: Animals_IdentityControllers/Create
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

         // GET: Animals_IdentityControllers/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: Animals_IdentityControllers/Edit/5
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

         // GET: Animals_IdentityControllers/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: Animals_IdentityControllers/Delete/5
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
