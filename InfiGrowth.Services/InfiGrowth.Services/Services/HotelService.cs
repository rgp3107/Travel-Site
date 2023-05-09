using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository.Interfaces;
using InfiGrowth.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IHotelRepository hotelRepository) {
            _hotelRepository = hotelRepository;
        }

        public async Task<Hotel> GetHotelById(Guid HotelId)
        {
            return await _hotelRepository.GetHotelById(HotelId);
        }
    }
}
