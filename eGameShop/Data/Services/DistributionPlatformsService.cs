using eGameShop.Data.Base;
using eGameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Data.Services
{
    public class DistributionPlatformsService : EntityBaseRepository<DistributionPlatform>, IDistributionPlatformsService
    {

        private readonly AppDbContext _context;
        public DistributionPlatformsService(AppDbContext context) : base(context) { }

    }
}
