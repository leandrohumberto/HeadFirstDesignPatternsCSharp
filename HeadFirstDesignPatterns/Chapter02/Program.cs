using Chapter02.Services;
using System;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            Console.WriteLine(currentConditionsDisplay.Info);

            weatherData.Temperature = 80;
            weatherData.Pressure = 65;
            weatherData.Humidity = 30.4f;
            Console.WriteLine(currentConditionsDisplay.Info);

            weatherData.Temperature = 82;
            weatherData.Pressure = 70;
            weatherData.Humidity = 29.2f;
            Console.WriteLine(currentConditionsDisplay.Info);

            weatherData.Temperature = 78;
            weatherData.Pressure = 90;
            weatherData.Humidity = 29.2f;
            weatherData.FinishMeasurement();
            Console.WriteLine(currentConditionsDisplay.Info);

            weatherData.Temperature = 73;
            weatherData.Pressure = 88;
            weatherData.Humidity = 31.22f;
            Console.WriteLine(currentConditionsDisplay.Info);

            Console.ReadKey();
        }
    }
}
