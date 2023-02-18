using eGameShop.Data;
using eGameShop.Data.Services;
using eGameShop.Data.Static;
using eGameShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class PlatformsController : Controller
    {
        private readonly IPlatformsService _service;

        public PlatformsController(IPlatformsService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allPlatforms = await _service.GetAllAsync();
            return View(allPlatforms);
        }

        //Get: Platforms/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Platform platform)
        {
            if (ModelState.IsValid)
            {
                return View(platform);
            }
            else
            {
                await _service.AddAsync(platform);
                return RedirectToAction(nameof(Index));
            }
        }


        //Get: Platforms/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);

            if (platformDetails == null) return View("NotFound");
            return View(platformDetails);
        }


        //Get: Platforms/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);

            if (platformDetails == null) return View("NotFound");
            return View(platformDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Platform platform)
        {

            if (ModelState.IsValid)
            {
                return View(platform);
            }
            else
            {
                await _service.UpdateAsync(id, platform);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: Platforms/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);

            if (platformDetails == null) return View("NotFound");
            return View(platformDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var platformDetails = await _service.GetByIdAsync(id);

            if (platformDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
