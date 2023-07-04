using ConputerShopAPI.Models;

namespace ConputerShopAPI.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product? GetProduct(int Id);
        Product AddProduct(Product product);
        Product? UpdateProduct(Product product);
        Product? DeleteProduct(int Id);
    }
}
