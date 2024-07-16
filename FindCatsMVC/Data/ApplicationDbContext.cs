using Microsoft.EntityFrameworkCore;
using FindCatsMVC.Models;

namespace FindCatsMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Cat> Cats { get; set; }
        public DbSet<FindCatsMVC.Models.User> User { get; set; } = default!;
    }
}
