using ConputerShopAPI.Data;
using ConputerShopAPI.Models;
using ConputerShopAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConputerShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productServ;
        public ProductsController(IProductService productServ)
        {
            _productServ = productServ;
        }
        

        [HttpGet]
        public ActionResult<IEnumerable<Product?>> GetProducts() => Ok(_productServ.GetProducts());

        [HttpGet("{id:int}")]
        public ActionResult<Product?> GetProduct(int id) 
        {
            if (_productServ.GetProduct(id) is null) return NotFound();
            return Ok(_productServ.GetProduct(id)); 
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product) 
        {
            var addedProduct =  _productServ.AddProduct(product);
            return CreatedAtAction(nameof(AddProduct), new { id = addedProduct.Id},addedProduct);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Product?> UpdateProduct(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            if (_productServ.UpdateProduct(product) is null) return NotFound(product.Id);
            return _productServ.UpdateProduct(product);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteProduct(int id)
        {
            if(_productServ.DeleteProduct(id) is null) return NotFound();
            return NoContent();
        }
    }
}
