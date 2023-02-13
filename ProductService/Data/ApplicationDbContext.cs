using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext>
            options):base(options)
        {

        }
        public DbSet<Products> Products { get; set; }

    }
}
