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
    public class CommentConfig: IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(b => b.book)
                .WithMany(c => c.comments)
                .HasForeignKey(c => c.book_id);

            //builder.HasOne(u => u.user) // user has many comments | comments FK => userID
            //    .WithMany(c => c.comments)
            //    .HasForeignKey(c => c.userID);

            builder.Property(c => c.text).HasMaxLength(255);


            new CommentSeeder().Seed(builder);
        }
    }
}
