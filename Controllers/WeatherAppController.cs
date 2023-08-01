using Microsoft.AspNetCore.Mvc;
using UygulamaHavuzum.Models;


namespace UygulamaHavuzum.Controllers
{
    public class WeatherAppController : Controller
        {
            public async Task<IActionResult> Index()
            {
                var apiKey = "145acfb47a93e3cd671c65c5c393e6a9";
                var CityWeathers = new List<WeatherModel>();

                List<string> Cities = new List<string>();
                Cities.Add("Sakarya");
                Cities.Add("Kırklareli");
                Cities.Add("Eskişehir");
                Cities.Add("Gaziantep");


                var _httpClient = new HttpClient();

                foreach (var city in Cities)
                {
                    var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}");
                    var WeatherJson = await response.Content.ReadAsStringAsync();
                    var CityObject = WeatherModel.FromJson(WeatherJson);

                    CityWeathers.Add(CityObject);
                }


                return View(CityWeathers);
            }
        }
    }
