using MattsSportsEmporium.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MattsSportsEmporium.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Tot = 0;
            ViewBag.Tax = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal Subtotal, Decimal TaxPercent, MattsSportsEmporiumModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tot = model.TotalCalculator();
                ViewBag.Tax = model.TaxCalculator();
            }
            else
            {
                ViewBag.Tot = 0;
                ViewBag.Tax = 0;
                
            }
            return View(model);
        }
    }
}
