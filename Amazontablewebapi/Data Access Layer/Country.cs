using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Country : ICountry
    {
        public async Task<List<AmazonCountries>> GetAllAmazonCountries()
        {
            return TempData.Data;
        }
        public async Task InsertAmazonCountry(AmazonCountries amazonCountries)
        {
            TempData.Data.Add(amazonCountries);
        }
        public async  Task DeleteAmazonCountry(int id)
        {
            TempData.Data = TempData.Data.Where(x => x.Id != id).ToList();
        }
       
    }
}
