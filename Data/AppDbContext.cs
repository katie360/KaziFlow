using KaziFlowApi.Models;
using Microsoft.EntityFrameworkCore;

namespace KaziFlowApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<User> Users { get; set; }
    }
}