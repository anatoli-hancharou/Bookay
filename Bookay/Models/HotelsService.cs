using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bookay.Models
{
    public class HotelsService : IHotelsService
    {
        private readonly BookayDbContext _dbContext;

        public HotelsService(BookayDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteAsync(long id)
        {
            _dbContext.Hotels.Remove(new Hotel { Id = id });
            await _dbContext.SaveChangesAsync();
        }

        public Hotel Find(long id) =>
            _dbContext.Hotels.FirstOrDefault(h => h.Id == id);

        public Task<Hotel> FindAsync(long id) =>
            _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);

        public IQueryable<Hotel> GetAll(int? count = null, int? page = null)
        {
            int actualCount = count.GetValueOrDefault(10);
            return _dbContext.Hotels
                .Skip(actualCount * page.GetValueOrDefault(0))
                .Take(actualCount);
        }

        public Task<Hotel[]> GetAllAsync(int? count = null, int? page = null) =>
            GetAll(count, page).ToArrayAsync();

        public async Task SaveAsync(Hotel hotel)
        {
            var isNew = hotel.Id == default;

            _dbContext.Entry(hotel).State = isNew ? EntityState.Added : EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
