using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KT> KTs { get; set; } 
    }
}