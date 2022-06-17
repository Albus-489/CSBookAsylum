using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project2.DAL.Entities;
using Project2.DAL.Configs;
using Project2.DAL.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Project2.DAL
{
    public class DBContext : IdentityDbContext<Users>
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

            modelBuilder.Entity<Users>(entity =>
            {
                new UserSeeder().Seed(entity);
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Role");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                new RolesSeeder().Seed(entity);
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=csFirstProj;Integrated Security=True;");
        }
    }
}

