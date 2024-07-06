using Ecommerce.Core.Entities;
using Ecommerce.Core.IRepositories;
using Ecommerce.Infrastructer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Net.Http.Headers;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdecutController : ControllerBase
    {
        readonly ApplicationDbContext _context;
        private readonly IProductRepository productRepository;
      //  private readonly IGenericRepository<Products> genericRepository;

        public ProdecutController(ApplicationDbContext context,IProductRepository productRepository)
        {
            _context = context;
            this.productRepository = productRepository;
          //  this.genericRepository = genericRepository;
            
        }

        [HttpGet]
        public IActionResult getAllProduct()
        {
            ///  var products = _context.Products.ToList();
            var products = productRepository.GetAll();
            return Ok(products);
            
        }
        [HttpGet("{id}")]
        public IActionResult getProductById(int id)
        {
            var products = productRepository.GetById(id);
            if(products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
        [HttpPost]
        public IActionResult createProduct(Products prodeuct)
        {
            productRepository.Create(prodeuct);
            return Ok(prodeuct);
        }

        [HttpPut]
        public IActionResult updateProduct(Products model)
        {
            productRepository.Update(model);
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteProduct(int id)
        {
            productRepository.Delete(id);
            return Ok();
        }
    }
}
