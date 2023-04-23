using Microsoft.EntityFrameworkCore;
using PracticaPuntoNetWeb.Models;

namespace PracticaPuntoNetWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
