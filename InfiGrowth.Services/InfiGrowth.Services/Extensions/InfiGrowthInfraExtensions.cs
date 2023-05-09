using InfiGrowth.Services.Helpers;
using InfiGrowth.Services.Services;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InfiGrowth.Services.Extensions
{
    public static class InfiGrowthServiceExtensions
    {
        public static IServiceCollection InfiGrowthInfraService(this IServiceCollection builder)
        {
            //All service needs to register for Dependency injection
            builder.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.AddScoped<ICustomerService, CustomerService>();
            builder.AddScoped<ICountryService, CountryService>();
            builder.AddScoped<IHotelService, HotelService>();
            builder.AddScoped<ICityService, CityService>();

            return builder;
        }
    }
}
