using EntitiesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataEntitesLayer
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=BlogApp;Uid=sa;Pwd=aysu123;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>()
               .HasOne(r => r.User)
               .WithMany(h => h.Posts)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comment>()
              .HasOne(r => r.User)
              .WithMany(h => h.Comments)
              .HasForeignKey(r => r.UserId)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comment>()
              .HasOne(r => r.Post)
              .WithMany(h => h.Comments)
              .HasForeignKey(r => r.PostId)
              .OnDelete(DeleteBehavior.Restrict);



        }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Comment> Comments { get; set; }

        
    }
}