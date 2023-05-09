using AutoMapper;
using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository;
using InfiGrowth.Infra.Repository.Interfaces;
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
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public Task<List<Country>> GetAllCountries()
        {
            return _countryRepository.GetAllCountries();
        }

        public Task<Country> GetCountryById(Guid CountryId)
        {
            return _countryRepository.GetCountryById(CountryId);
        }

        public async Task<Country> GetCountryByName(string CountryName)
        {
            return await _countryRepository.GetCountryByName(CountryName);
        }
    }
}
