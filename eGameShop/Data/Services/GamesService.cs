using eGameShop.Data.Base;
using eGameShop.Data.ViewModels;
using eGameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Data.Services
{
    public class GamesService : EntityBaseRepository<Game>, IGamesService
    {

        private readonly AppDbContext _context;
        public GamesService(AppDbContext context) : base(context) 
        { 
            _context = context;
        }

        public async Task<Game> GetGameByIdAsync(int id)
        {
            var gameDetails = await _context.Games
                .Include(pu => pu.Publisher)
                .Include(plat => plat.Platform)
                .Include(dis => dis.DistributionPlatform)
                .Include(pg => pg.Producers_Games).ThenInclude(p => p.Producer)
                .FirstOrDefaultAsync(n => n.Id == id);

            return gameDetails;




        }

        public async Task<NewGameDropdownsVM> GetNewGameDropdownsValues()
        {
            var response = new NewGameDropdownsVM()
            {
            Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync(),
            DistributionPlatforms = await _context.DistributionPlatforms.OrderBy(n => n.Name).ToListAsync(),
            Platforms = await _context.Platforms.OrderBy(n => n.Name).ToListAsync(),
            Publishers = await _context.Publishers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;

        }

        //private readonly AppDbContext _context;
        //public ProducersService(AppDbContext context)
        //{
        //    _context = context;
        //}

        ////public async Task AddAsync(Producer producer)
        ////{
        ////    await _context.Producers.AddAsync(producer);
        ////    await _context.SaveChangesAsync();
        ////}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
        //    _context.Producers.Remove(result);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Producer>> GetAllAsync()
        //{
        //    var result = await _context.Producers.ToListAsync();
        //    return result;
        //}

        //public async Task<Producer> GetByIdAsync(int id)
        //{
        //    var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
        //    return result;  
        //}

        //public async Task<Producer> UpdateAsync(int id, Producer newProducer)
        //{
        //    _context.Update(newProducer);
        //    await _context.SaveChangesAsync();
        //    return newProducer;
        //}
    }
}
