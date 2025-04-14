using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter your city:");
        var city = Console.ReadLine();

        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.Development.json", optional: true)
            .Build();

        var apiKey = config["ApiKeys:OpenWeather"];
        //Console.WriteLine($"DEBUG: apiKey is {apiKey}");

        var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        using var client = new HttpClient();
        try
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            //Console.WriteLine("DEBUG: Raw JSON:\n" + json);

            var weather = JsonSerializer.Deserialize<WeatherResponse>(json);

            if (weather != null && weather.Main != null && weather.Weather?.Length > 0)
            {
                Console.WriteLine($"\nWeather in {weather.Name}:");
                Console.WriteLine($"Temperature: {weather.Main.Temp}°C");
                Console.WriteLine($"Description: {weather.Weather[0].Description}");
            }
            else
            {
                Console.WriteLine("Could not read weather data properly.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong:");
            Console.WriteLine(ex.Message);
        }
    }
}
