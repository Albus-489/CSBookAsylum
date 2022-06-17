using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project2.DAL.Entities;
using Project2.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Seeding
{
    public class UserSeeder : ISeeder<Users>
    {

        private readonly List<Users> _users = new()
        {
            new Users
            {
                UserName = "superadmin",
                Email = "superadmin@gmail.com",
                FirstName = "super",
                LastName = "admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            }

        };
        public void Seed(EntityTypeBuilder<Users> builder) => builder.HasData(_users);
    }
}
