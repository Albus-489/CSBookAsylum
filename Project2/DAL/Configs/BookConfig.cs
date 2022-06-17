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
    public class BookConfig : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(o => o.author)
                .WithMany(u => u.books)
                .HasForeignKey(o => o.authorId);

            builder.Property(o => o.name).HasMaxLength(100);

            new BookSeeder().Seed(builder);
        }
    }
}
