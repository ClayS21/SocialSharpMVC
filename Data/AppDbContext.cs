using Microsoft.EntityFrameworkCore;
using SocialSharpMVC.Data.Models;

namespace SocialSharpMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(u => u.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
