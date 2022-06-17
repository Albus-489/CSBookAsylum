using Dapper;
using DapperLabFirstProject.Models;
using DapperLabFirstProject.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperLabFirstProject.Repository
{
    public class BranchesRepository : GenericRepo<Branches>, IBranchesRepository
    {
        public BranchesRepository(IDbTransaction transaction) : base("Branches", transaction)
        {

        }
    }
}
