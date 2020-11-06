using Microsoft.EntityFrameworkCore.Storage;
using ProductsApi.Entities;
using ProductsApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Data
{
    public class ProductRepository:IProductRepository
    {
        private DatabaseContext _context;
        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

    

        public void Delete(int id)
        {
            var productToBeDeleted = _context.Products.First(p => p.Id == id);
            if (productToBeDeleted != null)
            {
                _context.Products.Remove(productToBeDeleted);
            }

            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
           return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {

            _context.Update(product);
            _context.SaveChanges();
        }
        public  List<Product> GetProductsWithPriceInRange(double firstNumber, double secondNumber)
        {
            return _context.Products.Where(p => p.Price >= firstNumber && p.Price <= secondNumber).ToList();
        }
        public  List<Product> GetProductsGreaterThanSpecifiedPrice( double price)
        {
            return _context.Products.Where(p => p.Price > price).ToList();
        }
    }
}
