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
    public class DistributionPlatformsController : Controller
    {
        private readonly IDistributionPlatformsService _service;

        public DistributionPlatformsController(IDistributionPlatformsService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allDisPlatforms = await _service.GetAllAsync();
            return View(allDisPlatforms);
        }

        //Get: DistributionPlatforms/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] DistributionPlatform Displatform)
        {

            if (ModelState.IsValid)
            {
                return View(Displatform);
            }
            else
            {
                await _service.AddAsync(Displatform);
                return RedirectToAction(nameof(Index));
            }

        }


        //Get: DistributionPlatforms/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var DisplatformDetails = await _service.GetByIdAsync(id);

            if (DisplatformDetails == null) return View("NotFound");
            return View(DisplatformDetails);
        }


        //Get: DistributionPlatforms/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var DisplatformDetails = await _service.GetByIdAsync(id);

            if (DisplatformDetails == null) return View("NotFound");
            return View(DisplatformDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] DistributionPlatform Displatform)
        {

            if (ModelState.IsValid)
            {
                return View(Displatform);
            }
            else
            {
                await _service.UpdateAsync(id, Displatform);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: DistributionPlatforms/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var DisplatformDetails = await _service.GetByIdAsync(id);

            if (DisplatformDetails == null) return View("NotFound");
            return View(DisplatformDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var DisplatformDetails = await _service.GetByIdAsync(id);

            if (DisplatformDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
