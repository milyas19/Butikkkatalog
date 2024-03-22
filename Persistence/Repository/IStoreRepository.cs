using Entities;

namespace Persistence.Repository
{
    public interface IStoreRepository
    {
        Task<List<Store>> GetAllStores();
        Task<Store> GetStoreByStoreId(int storeId);
    }
}
