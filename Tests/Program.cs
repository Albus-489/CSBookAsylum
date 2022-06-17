using Microsoft.Data.SqlClient;
using Project2.DAL;
using Project2.DAL.Entities;

var dbFactory = new DBContextFactory();

var asd = new string[1];

using (DBContext db = dbFactory.CreateDbContext(asd))
{
    bool isAvalaible = db.Database.CanConnect();
    // bool isAvalaible2 = await db.Database.CanConnectAsync();
    if (isAvalaible) Console.WriteLine("Connected to db");
    else Console.WriteLine("Connection error");
}