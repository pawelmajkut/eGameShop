using eGameShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Controllers
{
    public class DistributionPlatformsController : Controller
    {
        private readonly AppDbContext _context;

        public DistributionPlatformsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allDistributionPlatforms = await _context.DistributionPlatforms.ToListAsync();
            return View();
        }
    }
}
