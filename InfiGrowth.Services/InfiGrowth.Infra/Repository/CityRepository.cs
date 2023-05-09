using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository
{
    public class CityRepository:ICityRepository
    {
        private readonly TravelContext _context;

        public CityRepository(TravelContext context) 
        { 
            _context = context;
        }

        public async Task<City> CreateCity(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
            return city;
        }

        public Task<List<City>> CreateMultipleCity()
        {
            throw new NotImplementedException();
        }

        public async Task<List<City>> GetAllCities()
        {
            return await _context.Cities.Include(x=>x.country).ToListAsync();
        }

        public Task<List<Experience>> GetAllExperienceByCityId(Guid cityId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hotel>> GetAllHotelsByCityId(Guid cityId)
        {
            throw new NotImplementedException();
        }
    }
}
