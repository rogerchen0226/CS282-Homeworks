using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherStationsLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WeatherData data = new WeatherData();

            Console.WriteLine("請輸入溫度:");
            double temperature = double.Parse(Console.ReadLine());

            data.Temperature = temperature;
            data.Humidity = 23;
            Console.WriteLine("你輸入的是{0}，結果是{1}", temperature, data.Temperature);
        }
    }
}