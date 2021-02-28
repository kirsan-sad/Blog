using Blog.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Infrastructure
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Blogdb;Username=postgres;Password=1234567890");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                    .HasMany(c => c.Categories)
                    .WithMany(p => p.Posts)
                    .UsingEntity(j => j.ToTable("PostBlog"));
        }
    }
}
