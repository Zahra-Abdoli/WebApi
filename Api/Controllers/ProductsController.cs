using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli2",
            Id =1,
            Description="pretty girls",
            Price=11
             },

            new Product
            {
            Name ="zahra kabdoli3",
            Id =1,
            Description="pretty girls",
            Price=11
            },
           new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli1",
            Id =1,
            Description="pretty girls",
            Price=11
            }

        };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = products.Find(p => p.Id == id);
            return product;
        }
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            products.Add(product);
        }
        [HttpGet("{id}")]
        public void Delete(int id)
        {
            var product = products.Where(p => p.Id == id);
            products = products.Except(product).ToList();
        }
        [HttpGet("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            var exitingProdct = products.Where(p => p.Id == id);
            products = products.Except(exitingProdct).ToList();
            products.Add(product);
        }
    }
}
