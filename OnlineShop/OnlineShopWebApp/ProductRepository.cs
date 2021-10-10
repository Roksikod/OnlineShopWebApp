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
            new Product ("Product1", 111, "Description1"),
            new Product ("Product2", 222, "Description2"),
            new Product ("Product3", 333, "Description3"),
            new Product ("Product4", 444, "Description4"),
        };
        
        public List<Product> GetAll()
        {
            return products;
        }
        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);

            //foreach (var product in products)
            //{
            //    if (product.Id==id)
            //    {
            //        return product;
            //    }
            //}
            //return null;
        }
    }
}
