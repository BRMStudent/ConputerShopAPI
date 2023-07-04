using ConputerShopAPI.Data;
using ConputerShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace ConputerShopAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ManagerDbContext _context;

        public ProductRepository(ManagerDbContext context) {
            _context = context;
        }

        public  IEnumerable<Product> GetAll()
        {
            return _context.Products.Include("ProductType");
        }

        public Product? Get(int Id)
        {
            return _context.Products.Include("ProductType").FirstOrDefault(p => p.Id == Id);
        }

        public Product Create(Product product)
        {
            EntityEntry<Product> result = _context.Products.Add(product);
            _context.SaveChanges();
            return result.Entity;
        }

        public  Product? Update(Product product)
        {
            Product? result =  _context.Products.Include("ProductType").FirstOrDefault(p => p.Id == product.Id);
            if (result != null) 
            { 
                result.Name = product.Name;
                result.UnitPrice = product.UnitPrice;
                result.Image = product.Image;
                result.Description = product.Description;

                _context.SaveChanges();
                return result;
            }
            return null;
        }

        public Product? Delete(int Id)
        {
            Product? result =  _context.Products.Include("ProductType").FirstOrDefault(p => p.Id == Id);
            if (result != null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
                return result;
            }
            return null;
        }
    }
}
