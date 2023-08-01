using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Diagnostics;
using UygulamaHavuzum.Models;

namespace UygulamaHavuzum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            var model = new List<UygulamaHavuzu>();

            model.Add(new UygulamaHavuzu { ApplicationName = "Yapılacaklar Listesi Uygulaması", Image =@"/img/todoapp.jpg", ApplicationController = " TodoApp", ApplicationAction = "Index" });

            model.Add(new UygulamaHavuzu { ApplicationName = "Vücut Kütle Endeksi Hesaplama Uygulaması",Image=@"/img/bmi.jpg", ApplicationController = "Calculator", ApplicationAction
                = "Index" });

            model.Add(new UygulamaHavuzu {ApplicationName = "Rastgele Özlü Söz Uygulaması", Image = @"/img/randomm.png", ApplicationController = "RandomQuotes", ApplicationAction = "Index"});
            
            model.Add(new UygulamaHavuzu { ApplicationName = "Hava Durumu Uygulaması", Image = @"/img/weatherr.png", ApplicationController = "WeatherApp", ApplicationAction = "Index" });
       
            return View(model);

            }
        public IActionResult Privacy()
        {
            return View();
        }
    }
    }