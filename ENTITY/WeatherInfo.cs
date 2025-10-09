using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class WeatherInfo
    {
        public Main main { get; set; }
        public Wind wind { get; set; }
        public List<Weather> weather { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double humidity { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
    }
}
