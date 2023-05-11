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
    public class BookingRepository : IBookingRepository
    {
        private readonly TravelContext _context;

        public BookingRepository(TravelContext context)
        {
            _context = context;
        }
        public async Task<Booking> CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            
            await _context.SaveChangesAsync();  
            return booking;
        }

        public async Task<Booking> DeleteBooking(Guid bookingId)
        {
            var book = await GetBookingById(bookingId);
            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Booking> GetBookingById(Guid bookingId)
        {
            return await _context.Bookings.FirstOrDefaultAsync(x=>x.BookingId==bookingId);
        }
    }
}
