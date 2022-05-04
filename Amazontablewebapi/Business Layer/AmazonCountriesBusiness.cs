using Data_Access_Layer;
using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class AmazonCountriesBusiness : IAmazonCountriesBusiness
    {

        private readonly ICountry _country;

        public AmazonCountriesBusiness(ICountry country)
        {
            _country = country;
        }

        public async Task<List<AmazonCountries>> GetAllAmazonCountries()
        {
           return await _country.GetAllAmazonCountries();
        }

        public async Task InsertAmazonCountry(AmazonCountries amazonCountries)
        {
            await _country.InsertAmazonCountry(amazonCountries);
        }

        public async Task DeleteAmazonCountry(int id)
        {
            await _country.DeleteAmazonCountry(id);
        }
    }



}
    

