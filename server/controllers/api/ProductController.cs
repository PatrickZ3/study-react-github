using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Category = "Fruits", Price = "$1", Stocked = true, Name = "Apple" },
                new Product { Id = 2, Category = "Fruits", Price = "$1", Stocked = true, Name = "Dragonfruit" },
                new Product { Id = 3, Category = "Fruits", Price = "$2", Stocked = false, Name = "Passionfruit" },
                new Product { Id = 4, Category = "Vegetables", Price = "$2", Stocked = true, Name = "Spinach" },
                new Product { Id = 5, Category = "Vegetables", Price = "$4", Stocked = false, Name = "Pumpkin" },
                new Product { Id = 6, Category = "Vegetables", Price = "$1", Stocked = true, Name = "Peas" }
            };
            return Ok(products);
        }
    }
}

// const PRODUCTS = [
//   { category: "Fruits", price: "$1", stocked: true, name: "Apple" },
//   { category: "Fruits", price: "$1", stocked: true, name: "Dragonfruit" },
//   { category: "Fruits", price: "$2", stocked: false, name: "Passionfruit" },
//   { category: "Vegetables", price: "$2", stocked: true, name: "Spinach" },
//   { category: "Vegetables", price: "$4", stocked: false, name: "Pumpkin" },
//   { category: "Vegetables", price: "$1", stocked: true, name: "Peas" },
// ];