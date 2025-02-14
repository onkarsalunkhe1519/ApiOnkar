using ApiOnkar.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiOnkar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}
