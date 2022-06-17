using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project2.DAL.Entities;
using Project2.DAL.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Configs
{
    public class CollectionConfig : IEntityTypeConfiguration<Collections>
    {
        public void Configure(EntityTypeBuilder<Collections> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(b => b.books)
                .WithMany(c => c.collections)
                .UsingEntity(bac => bac.ToTable("BookToCollection")); // bac = book and collection

            builder.Property(o => o.name).HasMaxLength(20);

            new CollectionSeeder().Seed(builder);
        }
    }
}
