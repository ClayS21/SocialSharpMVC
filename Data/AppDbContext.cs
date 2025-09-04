using Microsoft.EntityFrameworkCore;
using SocialSharpMVC.Data.Models;

namespace SocialSharpMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Post> Posts { get; set; }
    }
}
