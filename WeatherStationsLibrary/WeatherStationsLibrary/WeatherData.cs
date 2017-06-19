using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationsLibrary
{
    public class WeatherData
    {
        private double temperature;
        private double humidity;
        private double pressure;

        public double Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                if (value > 40)
                {
                    this.temperature = 40;
                }
                else if (value < -10)
                {
                    this.temperature = -10;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }

        public double Humidity
        {
            get
            {
                return this.humidity;
            }

            set
            {
                if (value > 100)
                {
                    this.humidity = 100;
                }
                else if (value < 0)
                {
                    this.humidity = 0;
                }
                else
                {
                    this.humidity = value;
                }
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }

            set
            {
                if (value > 1)
                {
                    this.pressure = 1;
                }
                else if (value < 0)
                {
                    this.pressure = 0;
                }
                else
                {
                    this.pressure = value;
                }
            }
        }

        public void SetTemperature(double value)
        {
            if (value > 40)
            {
                this.temperature = 40;
            }
            else if (value < -10)
            {
                this.temperature = -10;
            }
            else
            {
                this.temperature = value;
            }
        }

        public double GetTemperature()
        {
            return this.temperature;
        }

        public bool Equals(WeatherData other)
        {
            return this.Temperature == other.Temperature && this.Humidity == other.Humidity && this.Pressure == other.Pressure;
        }
    }
}