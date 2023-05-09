using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> GetAllCountries();
        Task<Country> GetCountryById(Guid CountryId);
        Task<Country> GetCountryByName(string CountryName);
    }
}
