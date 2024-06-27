using ProductManagementAPI.Models;

namespace ProductManagementAPI.Services
{
    public interface IProductServices
    {
        Product AddProduct(Product product);
        IEnumerable<Product> GetAllProduct();
        IEnumerable<Product> GetProductByAmount(double amount);
        Product UpdateProduct(Guid id, Product product);
        bool DeleteProduct(Guid id);
    }
}
