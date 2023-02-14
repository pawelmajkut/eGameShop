using eGameShop.Models;

namespace eGameShop.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAll();

        Producer GetById(int id);

        void Add(Producer producer);

        Producer Update(int id, Producer newProducer); 

        void Delete(int id);    
    }
}
