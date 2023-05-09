using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly TravelContext _context;

        public HotelRepository(TravelContext context) {
            _context = context;
        }

        public async Task<Hotel> GetHotelById(Guid HotelId)
        {
            return await _context.Hotels.FindAsync(HotelId);
        }
    }
}
