using Microsoft.EntityFrameworkCore;
using DressUp.Infrastructure.Data;
using DressUp.Infrastructure.Data.Repositories;
using DressUp.Infrastructure.Data.Common;
using DressUp.Core.Contracts;
using DressUp.Core.Services;
using CloudinaryDotNet;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {         
            services.AddScoped<IApplicationDbRepository, ApplicationDbRepository>();
            services.AddScoped<IAdminServices, AdminServices>();          
            services.AddScoped<IClothesServices, ClothesServices>();
            services.AddScoped<IBagsServices, BagsServices>();
            services.AddScoped<IShoesServices, ShoesServices>();
            services.AddScoped<IAccessoriesServices, AccessoriesServices>();
            services.AddScoped<ICartServices, CartServices>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}