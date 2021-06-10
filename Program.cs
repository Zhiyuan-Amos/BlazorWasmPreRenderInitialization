using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlazorWasmPreRenderInitialization
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services
                .AddSingleton<WeatherService>();

            var host = builder.Build();

            var weatherService = host.Services.GetRequiredService<WeatherService>();
            await weatherService.InitializeWeatherAsync();

            await host.RunAsync();
        }
    }
}
