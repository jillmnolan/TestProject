using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestApp.Api.Controllers
{
    public class ProductsController
    {
        [ApiController]
        [Route("controller")]
        public class ProductsController : ControllerBase {
            private readonly ILogger<ProductsController> _logger
            public ProductsController(ILogger<ProductsController> logger) {
                _logger = logger;
            }
        [HttpGet]
        public IEnumerable<Product> Get() {
            var rng = new Random();
            return Enumerable.Range(0, 10).Select(index => new Product {
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
        }
        }
    }
}