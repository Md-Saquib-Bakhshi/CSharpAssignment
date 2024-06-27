using ProductManagementAPI.Models;

namespace ProductManagementAPI.Services
{
    public class ProductServices : IProductServices
    {
        private List<Product> _productsList = new List<Product>();

        public Product AddProduct(Product product)
        {
            _productsList.Add(product);
            return product;
        }

        public bool DeleteProduct(Guid id)
        {
            var deleteProduct = _productsList.FirstOrDefault(x => x.Id == id);
            if (deleteProduct == null)
            {
                return false;
            }
            _productsList.Remove(deleteProduct);
            return true;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _productsList;
        }

        public IEnumerable<Product> GetProductByAmount(double amount)
        {
            var productByAmount = _productsList.FindAll(x=> x.Amount > amount);
            if (productByAmount != null)
            {
                return productByAmount;
            }
            return null;
        }

        public Product UpdateProduct(Guid id, Product product)
        {
            var updateProduct = _productsList.FirstOrDefault(x => x.Id == id);
            if(updateProduct != null)
            {
                updateProduct.Name = product.Name;
                updateProduct.Description = product.Description;
                updateProduct.Amount = product.Amount;
                return updateProduct;
            }
            return null;
        }
    }
}
