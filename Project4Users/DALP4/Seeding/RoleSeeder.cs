using DALP4.Interfaces;
using Microsoft.AspNetCore.Identity;
using DALP4.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DALP4.Seeding
{
    public class RolesSeeder : ISeeder<IdentityRole>
    {
        private readonly List<IdentityRole> _roles = new()
        {
            new IdentityRole(Roles.SuperAdmin.ToString()),
            new IdentityRole(Roles.Admin.ToString()),
            new IdentityRole(Roles.Moderator.ToString()),
            new IdentityRole(Roles.Redactor.ToString()),
            new IdentityRole(Roles.Basic.ToString()),
        };

        public void Seed(EntityTypeBuilder<IdentityRole> builder) =>
            builder.HasData(_roles);
    }
}
