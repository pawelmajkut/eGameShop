using eGameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }

        public Producer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Producer Update(int id, Producer newProducer)
        {
            throw new NotImplementedException();
        }
    }
}
