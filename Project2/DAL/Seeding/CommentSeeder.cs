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
    public class CommentSeeder : ISeeder<Comments>
    {

        private readonly List<Comments> comments = new()
        {
            //new Comments
            //{
            //    Id = 1,
            //    name = "Name 1",
            //    birth = DateTime.Now,
            //    death = DateTime.Now,
            //    rating = 100,
            //    bio = "Some 1st bio"
            //}
        };
        public void Seed(EntityTypeBuilder<Comments> builder) => builder.HasData(comments);
    }
}
