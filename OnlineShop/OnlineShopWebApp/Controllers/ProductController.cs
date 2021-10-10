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
        public string Index (int Id)
        {
            var product = productRepository.TryGetById(Id);
            if (product==null)
            {
                return $"There is no product with Id = {Id}";
            }
            return $"{product}\n{product.Descpirtion}";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
