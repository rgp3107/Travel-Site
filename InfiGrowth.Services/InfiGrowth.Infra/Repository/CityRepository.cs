using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository
{
    public class CityRepository:ICityRepository
    {
        private readonly TravelContext _context;

        public CityRepository(TravelContext context) 
        { 
            _context = context;
        }

        public async Task<City> CreateCity(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
            return city;
        }

        public async Task<List<City>> CreateMultipleCity()
        {
             var cityList = new List<City>();
             string path = @"D:\\tav.json";
             string json = File.ReadAllText(path);
             dynamic data = JsonConvert.DeserializeObject(json);

            foreach(var item in data)
            {
                Console.WriteLine(item);
            }

            return  cityList ;
        }

        public async Task<List<City>> GetAllCities()
        {
            //string path = @"E:\skyttus-1\Projects\Travel\tav.json";
            //string path = @"D:\\tav.json";
            //string json = File.ReadAllText(path);
            //dynamic data = JsonConvert.DeserializeObject(json);

            //foreach (var item in data)
            //{
            //    var hotel = new Hotel();
            //    hotel.HotelId = Guid.NewGuid();
            //    hotel.HotelName = item.property_name;
            //    hotel.HotelAddress = item.address;
            //    hotel.HotelImage = "https://images.pexels.com/photos/70441/pexels-photo-70441.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1";
            //    string c = item.city;
            //    bool city = _context.Cities.Any(x => x.CityName == (c));
            //    if (city)
            //    {
            //        var id = _context.Cities.FirstOrDefault(x => x.CityName == (c)).CityId;
            //        var id = _context.Cities.FirstOrDefault(x=>x.CityName == (c)).CityId;
            //        hotel.CityId = id;
            //        var rnd = new Random();
            //        hotel.HotelPrice = rnd.Next(1000, 10000);
            //        _context.Hotels.Add(hotel);
            //        await _context.SaveChangesAsync();
            //    }

            //}
            return await _context.Cities.Include(x=>x.country).ToListAsync();
        }

        public Task<List<Experience>> GetAllExperienceByCityId(Guid cityId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Hotel>> GetAllHotelsByCityId(Guid cityId)
        { 
            var city = await _context.Hotels.Where(x=>x.CityId == cityId).ToListAsync();
            return city;
            
        }


        public async Task<List<Hotel>> GetAllHotelsByCityName(string cityName)
        {

            var query = from h in _context.Hotels
                        join c in _context.Cities on h.CityId equals c.CityId
                        where c.CityName == cityName
                        select h ;
            return query.ToList();
            
        }

        public async Task<City> GetCityByName(string city)
        {
           return await _context.Cities.Where(x => x.CityName.ToLower() == city.ToLower()).FirstOrDefaultAsync();
            
        }
    }
}
