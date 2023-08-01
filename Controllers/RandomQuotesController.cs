using Microsoft.AspNetCore.Mvc;
using UygulamaHavuzum.Models;

namespace UygulamaHavuzum.Controllers
{
	public class RandomQuotesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var apiUrl = "https://api.quotable.io/random";
            var _httpClient = new HttpClient();
            var response = await _httpClient.GetAsync($"{apiUrl}");
            var quoteJson = await response.Content.ReadAsStringAsync();
            var quoteObject = RandomQuotes.FromJson(quoteJson);
            return View(quoteObject);
        }
    }
}
