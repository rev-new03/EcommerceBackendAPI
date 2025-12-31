using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceBackendAPI.Models;
using EcommerceBackendAPI.Data;

namespace EcommerceBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EcommerceDbContext _context;

        public ProductsController(EcommerceDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProductsById(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product); 
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProductsById), new { id = product.ProductId }, product);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
           if(id != updatedProduct.ProductId)
            {
                return BadRequest("ProductID is mismatch");
            }
            var existingProduct = _context.Products.Find(id);
            if(existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = updatedProduct.Name;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Stock = updatedProduct.Stock;
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
