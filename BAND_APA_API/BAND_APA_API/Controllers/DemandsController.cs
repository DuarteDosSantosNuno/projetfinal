using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using band_apa_api.Entities;
using Microsoft.Extensions.Logging;
using band_apa_api.Repositories;


namespace band_apa_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DemandsController : Controller
    {

        private readonly ILogger<DemandsController> _logger;
        private readonly IDemandRepository _demandRepository;
        public DemandsController(IDemandRepository demandRepository, ILogger<DemandsController> logger)
        {
            _logger = logger;
            _demandRepository = demandRepository;
        }
        // GET: DemandController
        [HttpGet("{id:int}")]
        public Demand GetById(int id)
        {
            return _demandRepository.FindById(id);
        }

        /*// GET: DemandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DemandController/Create
        public ActionResult Create()
        {
            return View();
        }
*/
        // POST: DemandController/Create
        /*[HttpPost]
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

        // GET: DemandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemandController/Edit/5
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

        // GET: DemandController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemandController/Delete/5
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
