using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project2.DAL.Entities;
using Project2.DAL.Configs;
using Project2.DAL.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Project2.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Collections> Collections { get; set; }

        public DBContext() : base()
        {
            Database.EnsureCreated();
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new CollectionConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=csSecondProjBooks;Integrated Security=True;");
        }
    }
}

