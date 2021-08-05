using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetcoreapi_vue_heroku_postgres_template.Models.entities;
using dotnetcoreapi_vue_heroku_postgres_template.Models.Tables;

namespace dotnetcoreapi_vue_heroku_postgres_template.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DataBaseEntity _context;   

        public ProductController(DataBaseEntity context)
        {
            _context = context;
        }

        [HttpGet] 
        public ActionResult<List<Product>> GetAll() 
        {     
            return _context.Products.ToList(); 
        } 

    }
}
