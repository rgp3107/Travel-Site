using InfiGrowth.Entity.Manage;
using InfiGrowth.Models.Dto;
using InfiGrowth.Services.Services;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService )
        {
            _bookingService = bookingService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBooking(Booking book)
        {
            return Ok(await _bookingService.CreateBooking(book));
        }
        [HttpGet]
        public async Task<IActionResult> GetBookingById(Guid bookId)
        {
            return Ok(await _bookingService.GetBookingById(bookId));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBooking(Guid bookId)
        {
            return Ok(await _bookingService.DeleteBooking(bookId));
        }
    }
}
