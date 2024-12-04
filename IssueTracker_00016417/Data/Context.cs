using IssueTracker_00016417.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker_00016417.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Developer> Developers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>().HasOne(i => i.Developer).WithMany(d => d.Issues).HasForeignKey(i => i.DeveloperId);
            modelBuilder.Entity<Issue>().HasOne(i => i.Category).WithMany(c => c.Issues).HasForeignKey(i => i.CategoryId);
            modelBuilder.Entity<Category>().HasMany(c=>c.Issues).WithOne(i=>i.Category).HasForeignKey(i => i.CategoryId);
            modelBuilder.Entity<Developer>().HasMany(d=>d.Issues).WithOne(i=>i.Developer).HasForeignKey(i => i.DeveloperId);
        }
    }
}
