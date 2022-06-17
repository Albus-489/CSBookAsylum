using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Project2.DAL.Entities
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 25;
        public int Rating { get; set; }
        public IList<Comments> comments { get; set; }
        public IList<RefreshToken> RefreshTokens { get; set; }

    }
}
