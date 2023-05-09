using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InfiGrowth.Infra.Extensions
{
    public static class TravelInfraExtensions
    {
        public static IServiceCollection InfiGrowthInfraServiceRegistration(this IServiceCollection builder, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TravelConnectionString");

            builder.AddDbContext<TravelContext>(options => {
                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging(true);
            });
            

            builder.AddScoped<DbContext, TravelContext>();
            builder.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.AddScoped<ICountryRepository, CountryRepository>();
            builder.AddScoped<IHotelRepository, HotelRepository>();
            builder.AddScoped<ICityRepository, CityRepository>();


            return builder;
        }

        public static IServiceCollection InfiGrowthInfraServiceRegistrationForBackground(this IServiceCollection builder, IConfiguration configuration)
        {
            //builder.ConfigureCoreInfra();

            var connectionString = configuration.GetConnectionString("TravelConnectionString");

            builder.AddDbContext<TravelContext>(
                options => options.UseSqlServer(connectionString),
                ServiceLifetime.Singleton);

            builder.AddTransient<ICustomerRepository, CustomerRepository>();
            builder.AddTransient<ICountryRepository, CountryRepository>();
            builder.AddTransient<IHotelRepository, HotelRepository>();
            builder.AddTransient<ICityRepository,CityRepository>();

            return builder;

        }

    }
}
