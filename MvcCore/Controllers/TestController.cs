using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;

namespace MvcCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        Product[] products = new Product[] {
            new Product { Id = 1, Name = "农夫山泉", Category = "water", Price = 2 },
            new Product { Id = 2, Name = "钢笔", Category = "study", Price = 3.75M },
            new Product { Id = 3, Name = "烤肠", Category = "food", Price = 1 },
            new Product { Id = 4, Name = "崂山矿泉水", Category = "water", Price = 2 },
            new Product { Id = 5, Name = "铅笔", Category = "study", Price = 3.75M },
            new Product { Id = 6, Name = "烤羊肉串", Category = "food", Price = 1 }
        };
        // GET: api/Test
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
