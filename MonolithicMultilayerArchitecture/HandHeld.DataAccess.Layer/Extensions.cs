using HandHeld.DataAccess.Layer.Options;
using HandHeld.DataAccess.Layer.Repositories.Implementations.DataBase;
using HandHeld.DataAccess.Layer.Repositories.Interfaces;
using HandHeld.DataAccess.Layer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HandHeld.Business.Layer")]
namespace HandHeld.DataAccess.Layer
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<HandHeldDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<IProductRepository,ProductRepository>();
            #region Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            #endregion
            #region Options
            services.Configure<ConfigSettingsOptions>(configuration.GetSection(ConfigSettingsOptions.Key));
            #endregion
            return services;
        }

    }
}
