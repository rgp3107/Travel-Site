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
    public class CountryRepository : ICountryRepository
    {
        private readonly TravelContext _context;
        public CountryRepository(TravelContext context) {
            _context = context;
        }

        public async Task<List<Country>> GetAllCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetCountryById(Guid CountryId)
        {
            return await _context.Countries.FindAsync(CountryId);
        }

        public async Task<Country> GetCountryByName(string CountryName)
        {
            return await _context.Countries.FindAsync(CountryName);
        }
    }
}
