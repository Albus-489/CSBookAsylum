using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DALP4
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=csProjectUsers;Integrated Security=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
