using Microsoft.Extensions.DependencyInjection;
using System;

namespace gRPCApiClient.Extensions
{
    public static class EnvironmentVariableExtensions
    {
        public static void AddEnvironmentVariables(this IServiceCollection services)
        {
            services.Configure<EnvironmentVariable>(
                    x => 
                    { 
                        x.gRPCServerUrl = Environment.GetEnvironmentVariable("gRPCServerUrl");                       
                    });
        }
    }
}
