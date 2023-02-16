using eGameShop.Data;
using eGameShop.Data.Services;
using eGameShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesService _service;

        public GamesController(IGamesService service)
        {
            _service = service;
        }
        //public IActionResult Index()
        //{
        //    var allPlatforms = _context.Platforms.ToList();
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            var allGames = await _service.GetAllAsync(n => n.Publisher);  /// nie jestem tego pewny - czy napewno Publisher ???
            return View(allGames);
        }

        //Get: Games/Create
        public async Task<IActionResult> Create()
        {
               var gameDropdownsData = await _service.GetNewGameDropdownsValues();

                ViewBag.DistributionPlatforms = new SelectList(gameDropdownsData.DistributionPlatforms, "Id", "Name");
                ViewBag.Producers = new SelectList(gameDropdownsData.Producers, "Id", "FullName");
                ViewBag.Publishers = new SelectList(gameDropdownsData.Publishers, "Id", "FullName");
                ViewBag.Platforms = new SelectList(gameDropdownsData.Platforms, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Game game)
        {

            if (ModelState.IsValid)
            {
                return View(game);
            }
            else
            {
                await _service.AddAsync(game);
                return RedirectToAction(nameof(Index));
            }

        }


        //Get: Games/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var gameDetails = await _service.GetGameByIdAsync(id);
            return View(gameDetails);

                        
        }


        //Get: Games/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var gameDetails = await _service.GetByIdAsync(id);

            if (gameDetails == null) return View("NotFound");
            return View(gameDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Game game)
        {

            if (ModelState.IsValid)
            {
                return View(game);
            }
            else
            {
                await _service.UpdateAsync(id, game);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: Games/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var gameDetails = await _service.GetByIdAsync(id);

            if (gameDetails == null) return View("NotFound");
            return View(gameDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameDetails = await _service.GetByIdAsync(id);

            if (gameDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));


        }
    }
}
