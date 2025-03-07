// See https://aka.ms/new-console-template for more information
using Serialize;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var weatherForecast = new WeatherForecast
        {
            Date = DateTime.Parse("2019-08-01"),
            TemperatureCelsius = 25,
            Summary = "Hot"
        };

        string jsonString = JsonSerializer.Serialize(weatherForecast);

        Console.WriteLine(jsonString);
    }
}

