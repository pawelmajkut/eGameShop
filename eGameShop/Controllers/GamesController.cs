using eGameShop.Data;
using eGameShop.Data.Enums;
using eGameShop.Data.Services;
using eGameShop.Data.Static;
using eGameShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace eGameShop.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class GamesController : Controller
    {
        private readonly IGamesService _service;

        public GamesController(IGamesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allGames = await _service.GetAllAsync(n => n.Publisher);
            return View(allGames);
        }


        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString, int pageNumber = 1, int pageSize = 10)
        {
            var allGames = await _service.GetAllAsync(n => n.Publisher);

            if (!string.IsNullOrEmpty(searchString))
            {
                var regex = new Regex(@"[\s\p{P}]");
                var searchWords = regex.Split(searchString.ToLower());

                var filteredResult = allGames
                    .Where(n => searchWords.All(w =>
                        n.Name.ToLower().Contains(w) ||
                        n.Description.ToLower().Contains(w) ||
                        n.GameCategory.ToString().ToLower().Contains(w)))
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                return View("Index", filteredResult);
            }

            var pagedResult = allGames
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return View("Index", pagedResult);
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
        public async Task<IActionResult> Create(NewGameVM game)
        {
            if (!ModelState.IsValid)
            {
                var gameDropdownsData = await _service.GetNewGameDropdownsValues();

                ViewBag.DistributionPlatforms = new SelectList(gameDropdownsData.DistributionPlatforms, "Id", "Name");
                ViewBag.Producers = new SelectList(gameDropdownsData.Producers, "Id", "FullName");
                ViewBag.Publishers = new SelectList(gameDropdownsData.Publishers, "Id", "FullName");
                ViewBag.Platforms = new SelectList(gameDropdownsData.Platforms, "Id", "Name");

                return View(game);
            }

            await _service.AddNewGameAsync(game);
            return RedirectToAction(nameof(Index));
        }

        //Get: Games/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var gameDetails = await _service.GetGameByIdAsync(id);
            return View(gameDetails);
        }

        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var gameDetails = await _service.GetGameByIdAsync(id);
            if (gameDetails == null) return View("NotFound");

            var response = new NewGameVM()
            {
                Id = gameDetails.Id,
                Name = gameDetails.Name,
                Description = gameDetails.Description,
                ImageURL = gameDetails.ImageURL,
                Price = gameDetails.Price,
                StartOfSale = gameDetails.StartOfSale,
                EndOfSale = gameDetails.EndOfSale,
                Quantity = gameDetails.Quantity,
                GameCategory = gameDetails.GameCategory,
                DistributionPlatformId = gameDetails.DistributionPlatformId,
                PlatformId = gameDetails.PlatformId,
                PublisherId = gameDetails.PublisherId,
                ProducerIds = gameDetails.Producers_Games.Select(n => n.ProducerId).ToList(),

            };

            var gameDropdownsData = await _service.GetNewGameDropdownsValues();

            ViewBag.DistributionPlatforms = new SelectList(gameDropdownsData.DistributionPlatforms, "Id", "Name");
            ViewBag.Producers = new SelectList(gameDropdownsData.Producers, "Id", "FullName");
            ViewBag.Publishers = new SelectList(gameDropdownsData.Publishers, "Id", "FullName");
            ViewBag.Platforms = new SelectList(gameDropdownsData.Platforms, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewGameVM game)
        {
            if (id != game.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var gameDropdownsData = await _service.GetNewGameDropdownsValues();

                ViewBag.DistributionPlatforms = new SelectList(gameDropdownsData.DistributionPlatforms, "Id", "Name");
                ViewBag.Producers = new SelectList(gameDropdownsData.Producers, "Id", "FullName");
                ViewBag.Publishers = new SelectList(gameDropdownsData.Publishers, "Id", "FullName");
                ViewBag.Platforms = new SelectList(gameDropdownsData.Platforms, "Id", "Name");

                return View(game);
            }

            await _service.UpdateGameAsync(game);
            return RedirectToAction(nameof(Index));
        }
    }
}
