using HandHeld.Business.Layer.Services.Implementations;
using HandHeld.Business.Layer.Services.Interfaces;
using HandHeld.DataAccess.Layer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HandHeld.Presentation.Layer")]
namespace HandHeld.Business.Layer
{
    internal static class Extensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services
            services.AddScoped<IProductService, ProductService>();
            #endregion
            services.AddDataAccess(configuration);
            return services;
        }
    }
}
