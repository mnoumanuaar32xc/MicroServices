using Microsoft.AspNetCore.Mvc;
using ProductService.Data;
using ProductService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;

        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return _context.Products.ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Products Get(int id)
        {
            return _context.Products.Where(x => x.Id == id).FirstOrDefault();

        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Products product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, product);


            }
            catch (Exception  ex )
            {

                return StatusCode(StatusCodes.Status501NotImplemented, product);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
