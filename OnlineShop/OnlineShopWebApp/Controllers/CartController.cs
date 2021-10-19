using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductRepository productRepository;

        public CartController()
        {
            productRepository = new ProductRepository();
        }
        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId)
            return View(product);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
