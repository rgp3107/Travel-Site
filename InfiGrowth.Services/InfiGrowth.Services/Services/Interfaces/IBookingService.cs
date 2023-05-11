using InfiGrowth.Entity.Manage;
using InfiGrowth.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services.Interfaces
{
    public interface IBookingService
    {
        Task<Booking> CreateBooking(Booking booking);

        Task<Booking> DeleteBooking(Guid bookingId);
        Task<Booking> GetBookingById(Guid bookingId);
    }
}
