﻿using System.Globalization;

namespace Secao9.Exercise1.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        } 
    }
}
