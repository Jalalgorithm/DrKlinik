using DrKlinik.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace DrKlinik.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
