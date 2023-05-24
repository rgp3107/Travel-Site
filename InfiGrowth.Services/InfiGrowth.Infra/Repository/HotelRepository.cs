using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
            string path = @"D:\\hotel.json";
            string json = File.ReadAllText(path);
            dynamic data = JsonConvert.DeserializeObject(json);

            var hotels = await _context.Hotels.ToListAsync();
            int j = 0;
            for (int i = 0; i < hotels.Count; i++)
            {
                hotels[i].HotelImage = data[j].Hotels;
                _context.Hotels.Update(hotels[i]);
                await _context.SaveChangesAsync();
                j++;

                if (j > 22)
                {
                    j = 0; 
                }
            }
           
            return await _context.Hotels.FindAsync(HotelId);
        }
    }
}
