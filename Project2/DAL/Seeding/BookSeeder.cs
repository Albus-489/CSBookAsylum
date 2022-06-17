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
    public class BookSeeder : ISeeder<Books>
    {

        private readonly List<Books> _books = new()
        {
            new Books
            {
                Id = 1,
                name = "Preview book 1",
                genre = "Preview genre 1",
                rating = 2,
                descriptionInfo = "No info 1"
            },
            new Books
            {
                Id = 2,
                name = "Preview book 2",
                genre = "Preview genre 2",
                rating = 90,
                descriptionInfo = "No info 2"
            }

        };
        public void Seed(EntityTypeBuilder<Books> builder) => builder.HasData(_books);
    }
}
