using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Fixxo.Core.Interface;
using Fixxo.NoSqlData.Services;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Data
{
    public static class NoSqlDataExtensions
    {
        public static IServiceCollection AddNoSqlData(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("NoSql");

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<NoSqlContext>(options =>
                options.UseCosmos(connString, "WIN21"));
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
