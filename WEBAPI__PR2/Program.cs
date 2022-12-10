using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project2.DAL;
using BLLP2.Services;
using Project2.DAL.Entities;
using System.Reflection;
using BLLP2.Configs;
using BLLP2.Interfaces;
using Project2.DAL.Interfaces;
using Project2.DAL.Repository;
//using WEBAPI_Project2.Helpers;
using FluentValidation;
using FluentValidation.AspNetCore;
//using Project2.WEBAPI_PR2.JWTManager;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using WEBAPI__PR2.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMapper();


//CORS SETTINGS
builder.Services.AddCors(op => op.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

builder.Services.Configure<ApplicationSettings>(option => builder.Configuration.GetSection("ApplicationSettings" ));

builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

var migrationsAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name;

builder.Services.AddDbContext<DBContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    }, ServiceLifetime.Transient);

builder.Services.AddTransient<DBContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//builder.Services.AddTransient<IIdentityService, IdentityService>();
//builder.Services.AddTransient<IIdentity, Identity>();
//builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddTransient<IBook, BookRepo>();
builder.Services.AddTransient<IAuthor, AuthorRepo>();
builder.Services.AddTransient<IComment, CommentRepo>();
builder.Services.AddTransient<ICollection, CollectionRepo>();



// +_+_+_+_+ BLL services +_+_+_+_+
// 
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddTransient<ICollectionService, CollectionService>();

//builder.Services.AddTransient<IValidatorFactory, ServiceProviderValidatorFactory>();
//builder.Services.AddMvc(options =>
//{
//    options.EnableEndpointRouting = false;
//}).AddFluentValidation(configuration =>
//{
//    configuration.RegisterValidatorsFromAssemblies(
//        AppDomain.CurrentDomain.GetAssemblies());
//});


//builder.Services.AddIdentityCore<Users>()
//                    .AddRoles<IdentityRole>()
//                    .AddSignInManager<SignInManager<Users>>()
//                    .AddDefaultTokenProviders()
//                    .AddEntityFrameworkStores<DBContext>();

builder.Services.AddMvc();



builder.Services.AddControllers();

var app = builder.Build();

//Jwt Authentication
//app.UseMiddleware<JwtMiddleware>();

var key = Encoding.UTF8.GetBytes(builder.Configuration["ApplicationSettings:JWT_Secret"].ToString());


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
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseAuthentication();
app.MapControllers();


app.Run();
