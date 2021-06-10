using System;
using System.Threading.Tasks;

namespace BlazorWasmPreRenderInitialization
{
    public class WeatherService
    {
        public async Task InitializeWeatherAsync()
        {
            Console.WriteLine("WeatherService: Initialization started");
            await Task.Delay(10000);
            Console.WriteLine("WeatherService: Initialization completed");
        }
    }
}
