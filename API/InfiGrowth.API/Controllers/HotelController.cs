using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService) {
            _hotelService = hotelService;
        }
        [HttpGet]
        public async Task<IActionResult> GetHotelById(Guid HotelId) 
        {
            return Ok (await _hotelService.GetHotelById(HotelId));
        }
    }
}
