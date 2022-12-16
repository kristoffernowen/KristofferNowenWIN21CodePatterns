using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Fixxo.Core.Interface;
using Fixxo.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Data
{
    public static class DataExtensions
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<SqlContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Sql")));
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
