using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAL.Entities;
using Project2.DAL.Repository;
using Microsoft.AspNetCore.Identity;

namespace Project2.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IBook Books { get; }
        public IAuthor Authors { get; }
        public IComment Comments { get; }
        public ICollection Collections { get; }
        //public UserManager<Users> UserManager { get; }
        //public RoleManager<IdentityRole> RoleManager { get; }
        //public SignInManager<Users> SignInManager { get; }

        public DBContext DBContext { get; }

        Task SaveChangesAsync();
    }
}
