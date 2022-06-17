using Project1.DAL.Data;
using Microsoft.Data.SqlClient;

var a = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=csFirstProj;Integrated Security=True");
a.Open();


var b = a.BeginTransaction();

UnitOfWork unitOfWork = new UnitOfWork(a, b);

//var table = unitOfWork.UsersRepository.GetAllAsync();
var table = unitOfWork.UsersRepository.GetAllAsync();

foreach (var item in table.Result)
{
    //Console.WriteLine($"|> ID: {item.id} | NAME: {item.name} | CREATOR: {item.telegram} <|");
}

Console.WriteLine("DAL");