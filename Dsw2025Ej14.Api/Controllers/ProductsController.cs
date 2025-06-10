using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
        [ApiController]
        [Route("api/products")]
        
    public class ProductsController : ControllerBase
    {
        private readonly IPersistencia _persistencia;

        public ProductsController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }
        [HttpGet()]
        public IActionResult GetProducts()
        {

            var products = _persistencia.GetProducts();
            if (products?.Any() == false) return NoContent();
            return Ok(products);
        }
        [HttpGet("{sku}")]
        public IActionResult GetProductBySku(string sku)
        {
            var product = _persistencia.GetProduct(sku);
            if (product != null)
            {
                return Ok(product); 
            }
            return NotFound(); 
        }
    }
}
