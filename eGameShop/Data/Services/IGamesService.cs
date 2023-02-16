using eGameShop.Data.Base;
using eGameShop.Models;

namespace eGameShop.Data.Services
{
    public interface IGamesService : IEntityBaseRepository<Game>
    {
        Task<Game> GetGameByIdAsync(int id);    

        //Task<IEnumerable<Producer>> GetAllAsync();

        //Task<Producer> GetByIdAsync(int id);

        //Task AddAsync(Producer producer);

        //Task<Producer> UpdateAsync(int id, Producer newProducer); 

        //Task DeleteAsync(int id);    
    }
}
