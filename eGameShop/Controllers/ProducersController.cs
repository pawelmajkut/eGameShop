using eGameShop.Data;
using eGameShop.Data.Services;
using eGameShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        //public IActionResult Index()
        //{
        //    var allProducers = _context.Producers.ToList();
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAll();
            return View(allProducers);
        }

        //Get: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Description")] Producer producer)
        {
			if (!ModelState.IsValid)
			{
				return View(producer);
			}
			_service.Add(producer);
			return RedirectToAction(nameof(Index));

		}
    }
}
