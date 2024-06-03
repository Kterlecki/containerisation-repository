using System.Net.Http;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var _httpClient = new HttpClient();
var response = await _httpClient.GetAsync("https://localhost:7096/WeatherForecast");
var content = await response.Content.ReadAsStringAsync();
Console.WriteLine(content);
