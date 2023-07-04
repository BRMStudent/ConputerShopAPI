using ConputerShopAPI.Models;
using ConputerShopAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConputerShopAPI.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public IEnumerable<Product> GetProducts()
        {
            return  _productRepo.GetAll();
        }

        public Product? GetProduct(int Id)
        {
            return  _productRepo.Get(Id);
        }

        public Product AddProduct(Product product)
        {
            return _productRepo.Create(product);
        }

        public Product? UpdateProduct(Product product)
        {
            return _productRepo.Update(product);
        }

        public Product? DeleteProduct(int Id)
        {
            return _productRepo.Delete(Id);
        }
    }
}
