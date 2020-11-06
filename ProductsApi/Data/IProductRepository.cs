using ProductsApi.Entities;
using ProductsApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Data
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();
        public Product GetById(int id);
        public void Update(Product product);
        public void Delete(int id);
        public List<Product> GetProductsWithPriceInRange(double firstNumber, double secondNumber);
        public List<Product> GetProductsGreaterThanSpecifiedPrice(double price);
    }
}
