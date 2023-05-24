using InfiGrowth.Entity.Manage;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CityController : ControllerBase
    {
        
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            return Ok(await _cityService.GetAllCities());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCity(City city)
        {
            return Ok(await _cityService.CreateCity(city));
        }
        [HttpGet("{CityName}")]
        public async Task<IActionResult> GetCityByName(string CityName)
        {
            return Ok(await _cityService.GetCityByName(CityName));
        }


        [HttpGet("GetAllHotelsByCityName")]
        public async Task<IActionResult> GetAllHotelsByCityName(string CityName)
        {
            return Ok(await _cityService.GetAllHotelsByCityName(CityName));
        }
        [HttpGet("GetAllHotelsByCityId")]
        public async Task<IActionResult> GetAllHotelsByCityId(Guid cityId)
        {
            return Ok(await _cityService.GetAllHotelsByCityId(cityId));
        }
        [HttpGet("GetAllTopCities")]
        public async Task<IActionResult> GetAllTopCities()
        {
            return Ok(await _cityService.GetAllTopCities());
        }
        [HttpGet("GetALLCityNames")]
        public async Task<IActionResult> GetAllCityNames()
        {
            return Ok(await _cityService.GetAllCityNames());
        }
    }
}
