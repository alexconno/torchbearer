using Microsoft.EntityFrameworkCore;

namespace Torchbearer.Models
{
    public partial class UnionLarpContext : DbContext
    {
        public UnionLarpContext()
        {
        }

        public UnionLarpContext(DbContextOptions<UnionLarpContext> options)
            : base(options)
        {
        }

        public DbSet<Skill> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
