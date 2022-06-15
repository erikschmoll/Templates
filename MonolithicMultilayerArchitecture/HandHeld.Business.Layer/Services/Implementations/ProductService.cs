using HandHeld.Business.Layer.Services.Interfaces;
using HandHeld.DataAccess.Layer.Repositories.Interfaces;

namespace HandHeld.Business.Layer.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<object> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
