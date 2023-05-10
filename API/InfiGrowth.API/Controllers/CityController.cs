﻿using InfiGrowth.Entity.Manage;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        [HttpGet("(CityId")]
        public async Task<IActionResult> GetAllHotelsByCityId(Guid CityId)
        {
            return Ok(await _cityService.GetAllHotelsByCityId(CityId));
        }
    }
}
