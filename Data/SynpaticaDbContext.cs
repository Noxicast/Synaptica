using Microsoft.EntityFrameworkCore;
using Synaptica.Shared.Models;

namespace Synaptica.Data
{
    public class SynpaticaDbContext : DbContext
    {
        public SynpaticaDbContext(DbContextOptions<SynpaticaDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}

