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
        public DbSet<SuggestedHelp> SuggestedHelp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuggestedHelp>()
                .HasKey(sh => new {sh.SkillId, sh.SuggestedHelpSkillId});
        }
    }
}
