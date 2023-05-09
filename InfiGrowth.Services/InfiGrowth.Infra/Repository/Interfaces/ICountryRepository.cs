using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAllCountries();
        Task<Country> GetCountryById(Guid CountryId);
        Task<Country> GetCountryByName(string CountryName);
    }
}
