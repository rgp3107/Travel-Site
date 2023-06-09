﻿using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository.Interfaces
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCities(); 

        Task<City> CreateCity(City city);

        Task<List<City>> CreateMultipleCity();

        Task<City> GetCityByName(string city);
        Task<List<City>> GetTopCities();

        Task<List<Hotel>> GetAllHotelsByCityId(Guid cityId);

        Task<List<Hotel>> GetAllHotelsByCityName(string cityName);

        Task<List<Experience>> GetAllExperienceByCityId(Guid cityId);
        Task<List<string>> GetAllCityNames();

    }
}
