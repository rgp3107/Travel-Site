using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services.Interfaces
{
    public interface ICityService
    {
        Task<List<City>> GetAllCities();

        Task<City> CreateCity(City city);

        Task<City> GetCityByName(string city);

        Task<List<Hotel>> GetAllHotelsByCityName(string city);

        Task<List<Hotel>> GetAllHotelsByCityId(Guid cityId);

        Task<List<City>> GetAllTopCities();

        Task<List<string>> GetAllCityNames();
    }
}
