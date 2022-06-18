using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project2.DAL;
using BLL_Project2.Services;
using Project2.DAL.Entities;
using System.Reflection;
using BLL_Project2.Configurations;
using BLL_Project2.Interfaces;
using Project2.DAL.Interfaces;
using Project2.DAL.Repository;
using WEBAPI_Project2.Helpers;
using FluentValidation;
using FluentValidation.AspNetCore;
using Project2.WEBAPI_PR2.JWTManager;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMapper();

builder.Services.AddCors(op => op.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

var migrationsAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name;

builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

builder.Services.AddIdentity<Users, IdentityRole>()
    .AddEntityFrameworkStores<DBContext>()
    ;


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


builder.Services.AddTransient<IIdentityService, IdentityService>();
builder.Services.AddTransient<IIdentity, Identity>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddTransient<IBook, BookRepo>();
builder.Services.AddTransient<IAuthor, AuthorRepo>();
builder.Services.AddTransient<IComment, CommentRepo>();
builder.Services.AddTransient<ICollection, CollectionRepo>();


builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<ICollectionService, CollectionService>();

builder.Services.AddTransient<IValidatorFactory, ServiceProviderValidatorFactory>();
builder.Services.AddMvc(options =>
{
    options.EnableEndpointRouting = false;
}).AddFluentValidation(configuration =>
{
    configuration.RegisterValidatorsFromAssemblies(
        AppDomain.CurrentDomain.GetAssemblies());
});


builder.Services.AddIdentityCore<Users>()
                    .AddRoles<IdentityRole>()
                    .AddSignInManager<SignInManager<Users>>()
                    .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<DBContext>();

builder.Services.AddMvc();



builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<JwtMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors();

app.UseEndpoints(x => x.MapControllers());

app.MapControllers();


app.Run();
