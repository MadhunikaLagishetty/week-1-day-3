using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public interface ICountry
    {
        public Task<List<AmazonCountries>> GetAllAmazonCountries();
        public Task InsertAmazonCountry(AmazonCountries amazonCountries);
        public Task DeleteAmazonCountry(int id);

    }
}
