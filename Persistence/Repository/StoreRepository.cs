using Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly ButikkKatalogContext _context;

        public StoreRepository(ButikkKatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Store>> GetAllStores() => await _context.Stores.ToListAsync();

        public async Task<Store> GetStoreByStoreId(int storeId)
        {
            var storeObj = await _context.Stores.Where(s => s.StoreId == storeId).FirstOrDefaultAsync();
            return storeObj;
        }
    }
}
