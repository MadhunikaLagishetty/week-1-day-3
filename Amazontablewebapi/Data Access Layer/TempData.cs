using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class TempData
    {
        public static List<AmazonCountries> Data { get; set; } = new List<AmazonCountries>();
    }
}
