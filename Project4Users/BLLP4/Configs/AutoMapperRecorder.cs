using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BLLP4.Configs
{
    public static class AutoMapperRecorder
    {
        public static IServiceCollection AddMapper(this IServiceCollection services) => services
            .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}
