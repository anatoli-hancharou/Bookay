using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bookay.Models
{
    public interface IHotelsService
    {
        Task DeleteAsync(long id);

        Hotel Find(long id);

        Task<Hotel> FindAsync(long id);

        IQueryable<Hotel> GetAll(int? count = null, int? page = null);

        Task<Hotel[]> GetAllAsync(int? count = null, int? page = null);

        Task SaveAsync(Hotel hotel);
    }
}
