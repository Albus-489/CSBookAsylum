using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project2.DAL.Entities;
using Project2.DAL.Enums;
using Project2.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Seeding
{
    public class RolesSeeder : ISeeder<IdentityRole>
    {

        private readonly List<IdentityRole> _roles = new()
        {
            new IdentityRole(Roles.SuperAdmin.ToString()),
            new IdentityRole(Roles.Admin.ToString()),
            new IdentityRole(Roles.Moderator.ToString()),
            new IdentityRole(Roles.Basic.ToString())
        };


        public void Seed(EntityTypeBuilder<IdentityRole> builder) => builder.HasData(_roles);
    }
}
