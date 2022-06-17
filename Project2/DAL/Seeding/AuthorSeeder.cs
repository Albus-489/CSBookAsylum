using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Seeding
{
    public class AuthorSeeder : ISeeder<Authors>
    {

        private readonly List<Authors> authors = new()
        {
            new Authors
            {
                Id = 1,
                name = "Name 1",
                birth = DateTime.Now,
                death = DateTime.Now,
                rating = 100,
                bio = "Some 1st bio"
            }

        };
        public void Seed(EntityTypeBuilder<Authors> builder) => builder.HasData(authors);
    }
}
