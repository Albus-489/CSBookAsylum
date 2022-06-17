using Dapper;
using Project1.DAL.Models;
using Project1.DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Project1.DAL.Data.Repository
{
    public class ThemesRepository : GenericRepo<Themes>, IThemesRepository
    {
        public ThemesRepository(IDbTransaction transaction) : base("Themes", transaction)
        {
            
        }
    }
}
