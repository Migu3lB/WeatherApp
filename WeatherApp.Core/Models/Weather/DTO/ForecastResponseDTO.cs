using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Models.Weather.DTO
{
    public class ForecastResponseDTO
    {
        public List<Period> Periods { get; set; }
    }
}
