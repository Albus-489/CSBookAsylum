using Project2.DAL.Entities;
using Project2.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Project2.DAL.Repository;

namespace Project2.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DBContext _dbContext;

        public IBook Books { get; }
        public IAuthor Authors { get; }
        public IComment Comments { get; }
        public ICollection Collections { get; }
        public UnitOfWork(IBook book, IAuthor author, IComment comment, ICollection collection,
            DBContext dbContext, UserManager<Users> userManager,RoleManager<IdentityRole> roleManager,SignInManager<Users> signInManager)
        {
            _dbContext = dbContext;

            Books = book;
            Authors = author;
            Comments = comment;
            Collections = collection;

            UserManager = userManager;
            RoleManager = roleManager;
            SignInManager = signInManager;
        }

        public UserManager<Users> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public SignInManager<Users> SignInManager { get; }
        public DBContext DBContext { get { return _dbContext; } }


        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
