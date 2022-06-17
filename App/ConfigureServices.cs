using System.Reflection;
using Project3.App.Behaviours;
using Project3.App.WorkWithModel.PostDir.GetById;
using Project3.App.WorkWithModel.PostDir.GetList;
using FluentValidation;
using MediatR;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
