using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountries();

        Task<int> Add(string countryCode, string countryName);

        Task<int> Delete(Country country);

        Task<int> Update(Country country);
    }
}
