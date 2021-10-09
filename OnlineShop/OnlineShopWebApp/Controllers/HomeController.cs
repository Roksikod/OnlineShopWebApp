using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> products = new List<Product>()
        {
            new Product ("Product1", 111, "Description1"),
            new Product ("Product2", 222, "Description2"),
            new Product ("Product3", 333, "Description3"),
            new Product ("Product4", 444, "Description4"),
        };
        
    public string Index()
    {
            var result = "";
            foreach (var product in products)
            {
                result += product + "\n\n";
            }
        return result;
    }

    public IActionResult Privacy()
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
