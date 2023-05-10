using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository.Interfaces;
using InfiGrowth.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services
{
    public class CityService:ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public Task<City> CreateCity(City city)
        {
            return _cityRepository.CreateCity(city);
        }

        public Task<List<City>> GetAllCities()
        {
            return _cityRepository.GetAllCities();
        }

        public async Task<List<Hotel>> GetAllHotelsByCityId(Guid cityId)
        {
            return await _cityRepository.GetAllHotelsByCityId(cityId);
        }

        public Task<City> GetCityByName(string city)
        {
            return _cityRepository.GetCityByName(city);
        }
    }
}
