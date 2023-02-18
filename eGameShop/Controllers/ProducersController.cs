﻿using eGameShop.Data;
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
    public class ProducersController : Controller
    {

        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
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

            if (ModelState.IsValid)
            {
                return View(producer);
            }
            else
            {
                await _service.AddAsync(producer);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: Producers/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }


        //Get: Producers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Description")] Producer producer)
        {

            if (ModelState.IsValid)
            {
                return View(producer);
            }
            else
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }

        }

        //Get: Producers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
