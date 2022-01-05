using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Infrastructure;
using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productServices;

        public ProductController(IProductServices ProductServices)
        {
            productServices = ProductServices;
        }

        [HttpGet("{id}")]
        public Products Get(int id)
        {
            return productServices.GetById(id);
        }
    }
}
