using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=csSecondProjBooks;Integrated Security=True;");

            return new DBContext(optionsBuilder.Options);
        }
    }
}

