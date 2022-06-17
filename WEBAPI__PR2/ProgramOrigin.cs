//using Project2.DAL;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Project2.DAL.Entities;
//using System.Reflection;
//using Microsoft.IdentityModel.Tokens;
//using System.Text;
//using Project2.DAL.Interfaces;
//using Project2.DAL.Repository;
//using Microsoft.OpenApi.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Data.SqlClient;
//using System.Data;
//using Project2.WEBAPI_PR2.JWTManager;
//using Project2.BLL.Interfaces;
//using Project2.BLL.Services;
//using WEBAPI_Project2.Helpers;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddCors();

//var migrationsAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name;

//builder.Services.AddDbContext<DBContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
//    );

//builder.Services.AddIdentity<Users, IdentityRole>()
//    .AddEntityFrameworkStores<DBContext>()
//    ;

//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
//builder.Services.AddTransient<IIdentity, Identity>();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddTransient<IBook, BookRepo>();
//builder.Services.AddTransient<IAuthor, AuthorRepo>();
//builder.Services.AddTransient<IComment, CommentRepo>();
//builder.Services.AddTransient<ICollection, CollectionRepo>();

//builder.Services.AddMvc(options =>
//{
//    options.EnableEndpointRouting = false;
//});

//builder.Services.AddMvc();

//var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//    app.UseDeveloperExceptionPage();
//}

//app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();

//app.UseAuthentication();

//app.MapControllers();


//app.Run();
