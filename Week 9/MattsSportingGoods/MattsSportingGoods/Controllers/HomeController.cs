﻿using MattsSportingGoods.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MattsSportingGoods.Controllers
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
            ViewBag.TaxAmount = 0;
            ViewBag.TotalSalePrice = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Sale productSale)
        {
            if(ModelState.IsValid)
            {
                ViewBag.TaxAmount = productSale.TaxAmount();
                ViewBag.TotalSalePrice = productSale.TotalSalePrice();
            }
            else
            {
                ViewBag.TaxAmount = 0;
                ViewBag.TotalSalePrice = 0;
            }
            
            return View(productSale);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}