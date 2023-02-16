using eGameShop.Data.Base;
using eGameShop.Data.ViewModels;
using eGameShop.Models;

namespace eGameShop.Data.Services
{
    public interface IGamesService : IEntityBaseRepository<Game>
    {
        Task<Game> GetGameByIdAsync(int id);
        Task<NewGameDropdownsVM> GetNewGameDropdownsValues();

        //Task<IEnumerable<Producer>> GetAllAsync();

        //Task<Producer> GetByIdAsync(int id);

        //Task AddAsync(Producer producer);

        //Task<Producer> UpdateAsync(int id, Producer newProducer); 

        //Task DeleteAsync(int id);    
    }
}
