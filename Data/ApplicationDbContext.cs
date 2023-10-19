using Microsoft.EntityFrameworkCore;
using PathfinderVisualizerAPI.Models;

namespace PathfinderVisualizerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<PathModel> AlgorithmPath { get; set; }

    }
}