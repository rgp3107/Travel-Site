using InfiGrowth.Entity.Manage;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService) {
            _countryService = countryService;
        }
        [HttpGet]
        public async Task<List<Country>> GetAllCountries()
        {
            return await _countryService.GetAllCountries(); 
        }
        [HttpGet("(CountryId)")]
        public async Task<Country> GetCountryById(Guid countryId)
        {
            return await _countryService.GetCountryById(countryId);
        }
        [HttpGet("(CountryName)")]
        public async Task<Country> GetCountryByName(string countryName)
        {
            return await _countryService.GetCountryByName(countryName);
        }
    }
}
