using ConputerShopAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConputerShopAPI.Repositories
{


    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product? Get(int Id);
        Product Create(Product product);
        Product? Update(Product product);
        Product? Delete(int Id);
    }
}
