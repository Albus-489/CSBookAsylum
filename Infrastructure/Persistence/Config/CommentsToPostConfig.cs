using Project3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Infrastructure.Persistence.Config
{
    public class CommentsToPostConfig:IEntityTypeConfiguration<ComentsToPost>
    {
        public void Configure(EntityTypeBuilder<ComentsToPost> builder)
        {
            builder.Property(p => p.text)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasOne(p => p.post)
                .WithMany(c => c.commentstopost)
                .HasForeignKey(p => p.post_id);

            builder.HasKey(p => p.Id);

        }
    }
}
