using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Models;
using ProductManagementAPI.Services;

namespace ProductManagementAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductServices _productServices;
        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody]Product product)
        {
            var addProduct = _productServices.AddProduct(product);
            return Ok(addProduct);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productServices.GetAllProduct();
            return Ok(products);
        }

        [HttpGet("{amount}")]
        public IActionResult GetProductByAmount(double amount)
        {
            var productByAmount = _productServices.GetProductByAmount(amount);
            if (productByAmount != null)
            {
                return Ok(productByAmount);
            }
            return NotFound($"No products found for amount > {amount}");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromRoute]Guid id, [FromBody]Product product)
        {
            var existingProduct = _productServices.UpdateProduct(id, product);
            if (existingProduct == null)
            {
                return NotFound($"No product found with id {id}");
            }
            return Ok($"Product with id {id} updated successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute]Guid id)
        {
            var deleteProduct = _productServices.DeleteProduct(id);
            if (!deleteProduct)
            {
                return NotFound($"No product found with id {id}");
            }
            return Ok($"Product with id {id} remove successfully.");
        }
    }
}
