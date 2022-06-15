using Microsoft.AspNetCore.Builder;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HandHeld.Business.Layer;
using HandHeld.Presentation.Layer.Middlewares;

[assembly: InternalsVisibleTo("HandHeld.Bootstrapper")]
namespace HandHeld.Presentation.Layer
{
    internal static class Module
    {
        public static IServiceCollection AddModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBusiness(configuration);
            return services;
        }
        public static IApplicationBuilder UseModule(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorMiddleware>();
            return app;
        }
    }
}