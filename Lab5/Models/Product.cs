using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
                
        }
        public Product(string name,int id, string descriptin,decimal price)
        {
            Id = id;
            Name = name;
            Description = descriptin;
            Price = price;

        }
    }
}
