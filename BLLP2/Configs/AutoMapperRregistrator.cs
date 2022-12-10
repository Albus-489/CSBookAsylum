using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace BLLP2.Configs;

public static class AutoMapperRegistrator
{
    public static IServiceCollection AddMapper(this IServiceCollection services) => services
        .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
}