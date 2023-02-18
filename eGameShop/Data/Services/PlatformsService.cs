using eGameShop.Data.Base;
using eGameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Data.Services
{
    public class PlatformsService : EntityBaseRepository<Platform>, IPlatformsService
    {
        private readonly AppDbContext _context;
        public PlatformsService(AppDbContext context) : base(context) { }

    }
}
