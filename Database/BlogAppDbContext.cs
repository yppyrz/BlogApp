using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Databae
{
    public class BlogAppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BlogAppDb;uid=sa;pwd=1234;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-O23KDVQ;Database=BlogAppDb;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);

        }
        // DbSet
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostTagRelation> Relations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // entity configürasyon işlemleri yapıyoruz.
            base.OnModelCreating(modelBuilder);
        }
    }
}
