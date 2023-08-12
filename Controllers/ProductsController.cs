using AspNetCoreWebAPI_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAPI_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context) {

            _context = context;

        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        [HttpPost]

        public IActionResult AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, product);
            }

            catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


    }
}
