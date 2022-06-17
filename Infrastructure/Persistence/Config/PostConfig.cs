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
    public class PostConfig:IEntityTypeConfiguration<Posts>
    {
        public void Configure(EntityTypeBuilder<Posts> builder)
        {
            builder.Property(c => c.text)
                .HasMaxLength(450)
                .IsRequired();

            builder.HasKey(c => c.Id);

        }
    }
}
