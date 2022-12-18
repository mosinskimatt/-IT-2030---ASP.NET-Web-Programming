using MattsSportingGoods.Models;
using Microsoft.AspNetCore.Mvc;

namespace MattsSportingGoods.Controllers
{
    public class SupportController : Controller
    {
        [HttpGet]
        public IActionResult Support()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Support(Customer customer)
        {
            var Customer = new Customer();
            return View(customer);
        }
    }
}
