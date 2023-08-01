using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UygulamaHavuzum.Models;

namespace UygulamaHavuzum.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMICalculatorModel bm)
        {
            var Height = bm.Height / 100;
            bm.BMIResult = bm.Weight / (Height * Height);

            if (bm.BMIResult < 18.5)
            {
                bm.YourBMI = "Under Weight";
            }
            else if (bm.BMIResult >= 18.5 && bm.BMIResult < 25)
            {
                bm.YourBMI = "Normal";
            }
            else if (bm.BMIResult >= 25 && bm.BMIResult < 30)
            {
                bm.YourBMI = "Over weight";
            }
            else if (bm.BMIResult >= 30)
            {
                bm.YourBMI = "Obese";
            }

            var jsoncalc = JsonConvert.SerializeObject(bm);
            return Json(jsoncalc);
        }

    }
}

