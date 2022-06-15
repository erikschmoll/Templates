using HandHeld.DataAccess.Layer.Models;
using HandHeld.DataAccess.Layer.Repository.Interfaces;

namespace HandHeld.DataAccess.Layer.Repositories.Interfaces
{
    public interface IProductRepository : _IBaseRepository<Product>
    {
        IEnumerable<object> GetProducts();
    }
}
