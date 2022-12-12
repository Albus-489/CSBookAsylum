using DALP4.Entities;
using DALP4.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DALP4.Seeding
{
    public class UserSeeder : ISeeder<AppUser>
    {
        private readonly List<AppUser> _users = new()
        {
            new AppUser()
            {
                UserName = "superadmin",
                Email = "superadmin@gmail.com",
                FirstName = "super",
                LastName = "admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            }
        };

        public void Seed(EntityTypeBuilder<AppUser> builder) =>
            builder.HasData(_users);
    }
}
