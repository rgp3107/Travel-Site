using AutoMapper;
using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository.Interfaces;
using InfiGrowth.Models.Dto;
using InfiGrowth.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepository bookingRepository,IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }
        public async Task<Booking> CreateBooking(Booking booking)
        {
            return await _bookingRepository.CreateBooking(booking);
        }

        public async Task<Booking> DeleteBooking(Guid bookingId)
        {
            return await _bookingRepository.DeleteBooking(bookingId);
        }

        public async Task<Booking> GetBookingById(Guid bookingId)
        {
            return await _bookingRepository.GetBookingById(bookingId);
        }
    }
}
