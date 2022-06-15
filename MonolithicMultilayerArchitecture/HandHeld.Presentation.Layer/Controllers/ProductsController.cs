using HandHeld.Business.Layer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HandHeld.Presentation.Layer.Controllers
{
    public class ProductsController : _BaseController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult<dynamic> Get()
        {
            return Ok(_productService.GetProducts());
        }
    }
}