// See https://aka.ms/new-console-template for more information
using Serialize;
using System.Text.Json;

var weatherForecast = new WeatherForecast
{
Date = DateTime.Parse("2019-08-01"),
TemperatureCelsius = 25,
Summary = "Hot"
};

string jsonString = JsonSerializer.Serialize(weatherForecast);
Console.WriteLine(jsonString);

var weatherForecastT = new WeatherForecast
{
    Date = DateTime.Parse("2019-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot"
};

string fileName = "WeatherForecast.json";
string jsonStringg = JsonSerializer.Serialize(weatherForecast);
File.WriteAllText(fileName, jsonString);

Console.WriteLine(File.ReadAllText(fileName));




