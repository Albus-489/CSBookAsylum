using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Interfaces
{
    public interface ISeeder<T> where T : class, new()
    {
        void Seed(EntityTypeBuilder<T> builder);
    }
}
