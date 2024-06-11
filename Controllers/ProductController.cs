using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductList.Interfaces;
using ProductList.Models;

namespace ProductList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("Get All Products")]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(_productRepository.GetAllProducts());
        }

        [HttpGet("Get Product by Id")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
