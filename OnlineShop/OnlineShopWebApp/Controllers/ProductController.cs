using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }
        public IActionResult Index (int Id)
        {
            var product = productRepository.TryGetById(Id);
            
            return View(product);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
