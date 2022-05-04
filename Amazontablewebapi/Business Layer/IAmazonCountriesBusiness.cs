using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public  interface IAmazonCountriesBusiness
    {
        public Task<List<AmazonCountries>> GetAllAmazonCountries();
        public Task InsertAmazonCountry(AmazonCountries amazonCountries);
        public Task DeleteAmazonCountry(int id);
    }
}
