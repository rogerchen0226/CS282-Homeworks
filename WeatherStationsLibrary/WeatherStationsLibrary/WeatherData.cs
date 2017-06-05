using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationsLibrary
{
    public class WeatherData
    {
        public double Temperature;
        public double Humidity;
        public double Pressure;

        public bool Equals(WeatherData other)
        {
            return this.Temperature == other.Temperature && this.Humidity == other.Humidity && this.Pressure == other.Pressure;
        }
    }
}