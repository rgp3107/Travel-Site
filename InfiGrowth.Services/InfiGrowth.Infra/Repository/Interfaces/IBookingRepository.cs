using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> CreateBooking(Booking booking);   

        Task<Booking> DeleteBooking(Guid bookingId);
        Task<Booking> GetBookingById(Guid bookingId);
        
    }
}
