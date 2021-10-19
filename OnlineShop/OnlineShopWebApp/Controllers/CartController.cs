using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductsRepository productRepository;

        public CartController()
        {
            productRepository = new ProductsRepository();
        }
        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId)
            return View(product);
        }

        public IActionResult Index()
        {
            var cart = CartsRepository.TryGetByUserId(Constants.UserId);
            return View();
        }
    }
}
