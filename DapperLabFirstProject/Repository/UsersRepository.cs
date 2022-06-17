using Dapper;
using DapperLabFirstProject.Models;
using DapperLabFirstProject.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperLabFirstProject.Repository
{
    public class UsersRepository : GenericRepo<Users>, IUsersRepository
    {
        public UsersRepository(IDbTransaction transaction) : base("Users", transaction)
        {

        }
    }
}
