using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet <Product> Product { get; set; }
    }
}
