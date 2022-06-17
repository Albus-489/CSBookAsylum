using Microsoft.EntityFrameworkCore;
using Project3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.App.Interfaces
{
    public interface IDbContext
    {
        DbSet<Posts> Posts { get; }

        DbSet<ComentsToPost> CommnetsToPosts { get; }
        DbSet<Tags> Tags { get; }
        DbSet<TagsToPosts> TagsToPosts { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
