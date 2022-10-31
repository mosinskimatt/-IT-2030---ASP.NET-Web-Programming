using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using TipCalculatorWk7.Models;

namespace TipCalculatorWk7.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      [HttpGet]
      public IActionResult Index()
      {
         ViewBag.Fifteen = 0;
         ViewBag.Twenty = 0;
         ViewBag.TwentyFive = 0;
         return View();                  

      }

      [HttpPost]
      public IActionResult Index(TipCalculator model)
      {
         if (ModelState.IsValid)
         {
            ViewBag.Fifteen = model.Fifteen();
            ViewBag.Twenty = model.Twenty();
            ViewBag.TwentyFive = model.TwentyFive();
         }
         else
         {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
         }
         return View(model);
      }
   }
}