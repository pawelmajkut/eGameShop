using eGameShop.Data.Base;
using eGameShop.Data.ViewModels;
using eGameShop.Models;

namespace eGameShop.Data.Services
{
    public interface IGamesService : IEntityBaseRepository<Game>
    {
        Task<Game> GetGameByIdAsync(int id);
        Task<NewGameDropdownsVM> GetNewGameDropdownsValues();

        Task AddNewGameAsync(NewGameVM data);

        Task UpdateGameAsync(NewGameVM data);


    }
}
