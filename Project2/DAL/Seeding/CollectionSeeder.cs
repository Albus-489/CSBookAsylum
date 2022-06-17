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
    public class CollectionSeeder : ISeeder<Collections>
    {

        private readonly List<Collections> collection = new()
        {

        };
        public void Seed(EntityTypeBuilder<Collections> builder) => builder.HasData(collection);
    }
}
