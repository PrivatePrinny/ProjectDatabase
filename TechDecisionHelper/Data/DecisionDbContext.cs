using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Models;

namespace ProjectDatabase.Data
{
    public class DecisionDbContext : DbContext
    {
        public DecisionDbContext(DbContextOptions<DecisionDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; } = null!;
    }
}
