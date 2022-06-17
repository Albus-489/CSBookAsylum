using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
    public class AppDbContextInit
    {
        private readonly ILogger<AppDbContextInit> _logger;
        private readonly ApplicationDbContext _context;

        public AppDbContextInit(ILogger<AppDbContextInit> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                if (_context.Database.IsSqlServer())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }
    }
}
