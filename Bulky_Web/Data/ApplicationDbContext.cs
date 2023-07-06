using Bulky_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
    }
}
