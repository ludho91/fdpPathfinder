using FdpPathfinder.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FdpPathfinder.API.Data
{
    public class PathfinderContext : DbContext
    {
        public PathfinderContext(DbContextOptions<PathfinderContext> options) : base(options)
        {
            
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}