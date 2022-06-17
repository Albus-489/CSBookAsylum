using Microsoft.Extensions.DependencyInjection;
using Project1.BLL.Interfaces;
using Project1.BLL.Services;

namespace Project1.BLL.Configs
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services.AddTransient<IUsersServices, UsersService>()

        ;
    }
}
