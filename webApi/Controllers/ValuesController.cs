using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        Product p = new Product();
        static List<Product> ProductItem = new List<Product>() {
            new Product(){ ID=1,Name="Clock",Price=250,Quantity=25},
             new Product(){ID=2,Name="Sofa",Price=350,Quantity=35},
              new Product(){ ID=3,Name="Desk",Price=450,Quantity=45},
               new Product(){ ID=4,Name="Table",Price=750,Quantity=15},
        };






        [HttpGet]
        public IList<Product> Get()
        {
            return ProductItem;
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product a = new Product();
            foreach (var item in ProductItem)
            {
                if (item.ID == id)
                {
                    a = item;
                }
            }
            return a;
        }



        // POST api/values
        [HttpPost]
        public IList<Product> Post([FromBody] Product value)
        {
            ProductItem.Add(value);
            return ProductItem;
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public IList<Product> Put(int id, [FromBody] Product value)
        {
            foreach (var item in ProductItem)
            {
                if (id == item.ID)
                {
                    item.Name = value.Name;
                    item.Price = value.Price;
                    item.Quantity = value.Quantity;
                }
            }
            return ProductItem;
        }



        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IList<Product> Delete(int id)
        {
            Product a = new Product();
            foreach (var item in ProductItem)
            {
                if (item.ID == id)
                {
                    a = item;
                }
            }
            ProductItem.Remove(a);
            return ProductItem;
        }
    }
}
