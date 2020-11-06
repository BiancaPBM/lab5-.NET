using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;
using ProductsApi.Entities;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("all")]
        public IActionResult GetAllProducts()
        {
            var products = _repository.GetAll();
            if (products.ToList().Count == 0)
                return NotFound();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product =_repository.GetById(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _repository.Delete(id);
            return StatusCode(204);
        }

      [HttpPut]
      public IActionResult UpdateProduct([FromBody] Product product)
        {
            _repository.Update(product);
            return StatusCode(204);
        }
        //https://localhost:5001/api/products/inrange?firstNumber=3&secondNumber=5
        [HttpGet("inrange")]
       public IActionResult GetProductsInRange([FromQuery] double firstNumber, [FromQuery] double secondNumber)
        {
            return Ok(_repository.GetProductsWithPriceInRange(firstNumber, secondNumber));
        }

        [HttpGet("greater")]
        public IActionResult GetGreaterProducts([FromQuery] double firstNumber)
        {
            return Ok(_repository.GetProductsGreaterThanSpecifiedPrice( firstNumber));
        }


    }
}