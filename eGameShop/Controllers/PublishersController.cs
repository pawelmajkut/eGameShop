using eGameShop.Data;
using eGameShop.Data.Services;
using eGameShop.Data.Static;
using eGameShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace eGameShop.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class PublishersController : Controller
    {
        private readonly IPublishersService _service;
        //private readonly AppDbContext _context;

        public PublishersController(IPublishersService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allPublishers = await _service.GetAllAsync();
            return View(allPublishers);
        }

        //Get: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Description")] Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                return View(publisher);
            }
            else
            {
                await _service.AddAsync(publisher);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: Publishers/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);

            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }


        //Get: Publishers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);

            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Description")] Publisher publisher)
        {

            if (ModelState.IsValid)
            {
                return View(publisher);
            }
            else
            {
                await _service.UpdateAsync(id, publisher);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: Publishers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);

            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);

            if (publisherDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
