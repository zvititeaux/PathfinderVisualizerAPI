using Microsoft.EntityFrameworkCore;
using PathfinderVisualizerAPI.Models;

namespace PathfinderVisualizerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<PathfindingModels> Paths { get; set; }

    }
}