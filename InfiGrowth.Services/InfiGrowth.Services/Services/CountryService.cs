using AutoMapper;
using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository;
using InfiGrowth.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly CountryRepository _CountryRepository;
        private readonly IMapper _mapper;

        public CountryService(CountryRepository countryRepository, IMapper mapper)
        {
            _CountryRepository = countryRepository;
            _mapper = mapper;
        }

        public Task<List<Country>> GetAllCountries()
        {
            return _CountryRepository.GetAllCountries();
        }

        public Task<Country> GetCountryById(Guid CountryId)
        {
            return _CountryRepository.GetCountryById(CountryId);
        }

        public async Task<Country> GetCountryByName(string CountryName)
        {
            return await _CountryRepository.GetCountryByName(CountryName);
        }
    }
}
