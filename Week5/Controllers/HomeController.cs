
using MattsSportsEmporium.Models;
using Microsoft.AspNetCore.Mvc;


namespace MattsSportsEmporium.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.TotalCalculator = 0;
            ViewBag.TaxCalculator = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(MattsSportsEmporiumModel model)
        {
            if (ModelState.IsValid) {
                ViewBag.TotalCalculator = model.TotalCalculator();
                ViewBag.TaxCalculator = model.TaxCalculator();
            }
            else
            {
                ViewBag.TotalCalculator = 0;
                ViewBag.TaxCalculator = 0;
            }
                
            return View(model);
        }


        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ProductsView()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
