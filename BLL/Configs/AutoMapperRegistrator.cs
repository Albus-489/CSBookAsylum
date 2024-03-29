﻿using Microsoft.Extensions.DependencyInjection;

namespace Project1.BLL.Configs
{
    public static class AutoMapperRegistrator
    {
        public static IServiceCollection AddMapper( this IServiceCollection services) => services
            .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}
