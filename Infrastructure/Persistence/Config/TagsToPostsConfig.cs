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
    public class TagsToPostsConfig : IEntityTypeConfiguration<TagsToPosts>
    {
        public void Configure(EntityTypeBuilder<TagsToPosts> builder)
        {

            builder.HasKey(ttp => new { ttp.post_id, ttp.tags_id });

        }
    }
}
