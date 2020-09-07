using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Models;

namespace WebApi2.Controllers
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
            Id =2,
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
            Id =3,
            Description="pretty girls",
            Price=11
            },
           new Product
            {
            Name ="zahra kabdoli1",
            Id =4,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli1",
            Id =5,
            Description="pretty girls",
            Price=11
            },
            new Product
            {
            Name ="zahra kabdoli1",
            Id =6,
            Description="pretty girls",
            Price=11
            }

        };
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.Find(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            if (products.Exists(p => p.Id == product.Id))
            {
                return Conflict();
            }
           
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, products);
        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Product>> Delete(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products = products.Except((IEnumerable<Product>)product).ToList();
            return products;
        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Product>> Put(int id, [FromBody] Product product)
        {
            if (id != product.Id) { return BadRequest(); }
            var exitingProdct = products.Where(p => p.Id == id);
            products = products.Except(exitingProdct).ToList();
            products.Add(product);
            return products;
        }
    }
}
