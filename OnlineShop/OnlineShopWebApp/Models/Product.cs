using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Descpirtion { get; }
        public string ImagePath { get; }
        public Product(string name, decimal cost, string descpirtion, string imagePath)
        {
            Id = instanceCounter;
            Name = name;
            Cost = cost;
            Descpirtion = descpirtion;

            instanceCounter += 1;
            ImagePath = imagePath;
        }
        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}\n{Descpirtion}\n{ImagePath}";
        }

    }
}
