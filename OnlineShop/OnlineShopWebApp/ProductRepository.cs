using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product ("Chromebook", 129, "HP - 11.6 Chromebook - Intel Celeron - 4GB Memory - 32GB eMMC Flash Memory - Ash Gray", "/images/Chromebook.jpg"),
            new Product ("Dell", 550, "Dell - Inspiron 15.6 FHD Touch-Screen Laptop -Intel Core i5 - 8GB Memory - 256GB SSD - Black", "/images/Dell.jpg"),
            new Product ("Laptop", 580, "HP - 17.3 Laptop - Intel Core i5 - 8GB Memory - 256GB SSD - Natural Silver", "/images/Laptop.jpg"),
            new Product ("Lenovo", 950, "Lenovo - Yoga 7i 2-in-1 14 Touch Screen Laptop - Intel Evo Platform Core i5 - 12GB Memory - 512GB Solid State Drive - Dark Moss", "/images/Lenovo.jpg"),            
            new Product ("MacBook", 444, "MacBook Air 13.3 Laptop - Apple M1 chip - 8GB Memory - 256GB SSD (Latest Model) - Space Gray", "/images/MacBook.jpg"),
        };
        
        public List<Product> GetAll()
        {
            return products;
        }
        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);            
        }
    }
}
