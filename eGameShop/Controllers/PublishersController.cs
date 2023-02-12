using eGameShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace eGameShop.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDbContext _context;

        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Publishers.ToList(); 
            return View();
        }
    }
}
