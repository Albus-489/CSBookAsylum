using Project1.DAL.Data.Repository;
using Project1.DAL.Interfaces;
using Project1.DAL.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using Project1.BLL.Services;
using Project1.BLL.Interfaces;
using Project1.BLL.Configs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IBranchesRepository, BranchesRepository>();
builder.Services.AddTransient<IUsersRepository, UsersRepository>();
builder.Services.AddTransient<IThemesRepository, ThemesRepository>();
builder.Services.AddTransient<IThemeMessageRepo, ThemeMessageRepo>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IUsersServices, UsersService>();

builder.Services.AddMapper();

builder.Services.AddScoped((s) => new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IDbTransaction>(s =>
{
    SqlConnection connection = s.GetRequiredService<SqlConnection>();
    connection.Open();
    return connection.BeginTransaction();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
