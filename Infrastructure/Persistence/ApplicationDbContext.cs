using MediatR;
using Microsoft.EntityFrameworkCore;
using Project3.App.Interfaces;
using Project3.Domain.Entities;
using Project3.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Infrastructure.Persistence
{
    public class ApplicationDbContext:DbContext, IDbContext
    {
        private readonly IMediator _mediator;

        public DbSet<Posts> Posts => Set<Posts>();

        public DbSet<ComentsToPost> CommnetsToPosts => Set<ComentsToPost>();

        public DbSet<Tags> Tags => Set<Tags>();

        public DbSet<TagsToPosts> TagsToPosts => Set<TagsToPosts>();

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
