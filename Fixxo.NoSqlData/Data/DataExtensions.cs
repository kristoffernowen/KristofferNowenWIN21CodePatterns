using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Fixxo.NoSqlData.Data;
using Fixxo.NoSqlData.Services;
using Microsoft.EntityFrameworkCore;
using Fixxo.Core.Interface.Services;

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
            services.AddScoped<IProductServiceNoSql, ProductService>();

            return services;
        }
    }
}
