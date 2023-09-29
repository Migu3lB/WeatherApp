using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.Weather
{
    public class RelativeLocation
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public WeatherProperties Properties { get; set; }
    }
}
