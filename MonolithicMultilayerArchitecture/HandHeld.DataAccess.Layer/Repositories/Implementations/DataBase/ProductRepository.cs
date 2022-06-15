using HandHeld.DataAccess.Layer.Models;
using HandHeld.DataAccess.Layer.Options;
using HandHeld.DataAccess.Layer.Repositories.Implementatios.DataBase;
using HandHeld.DataAccess.Layer.Repositories.Interfaces;
using Microsoft.Extensions.Options;

namespace HandHeld.DataAccess.Layer.Repositories.Implementations.DataBase
{
    public class ProductRepository : _BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(HandHeldDbContext context, IOptions<ConfigSettingsOptions> options) : base(context) {

            var opt = options.Value;
        }

        public IEnumerable<object> GetProducts()
        {
            return new List<string>() { "one", "two", "three", "four" };
        }
    }
}
