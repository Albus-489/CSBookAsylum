//using Project2.DAL;
//using Microsoft.Data.SqlClient;

//var a = new SqlConnection("Server=(localdb)\\mssqllocaldb;Initial Catalog=csFirstProj;Integrated Security=True");
//a.Open();


//var b = a.BeginTransaction();

//UnitOfWork unitOfWork = new UnitOfWork(a, b);

////var table = unitOfWork.UsersRepository.GetAllAsync();
//var table = unitOfWork.Books.GetAllAsync();

//foreach (var item in table.Result)
//{
//    Console.WriteLine($"|> ID: {item.Id} | NAME: {item.name} <|");
//}