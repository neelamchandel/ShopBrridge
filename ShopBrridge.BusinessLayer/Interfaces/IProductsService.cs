using ShopBrridge.DataAccessLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBrridge.BusinessLayer.Interfaces
{
    public interface IProductsService
    {
        Task<List<Product>> GetAllProducts();

        Task<int> AddProductAsync(Product product);

        Task<int> DeleteProduct(int productId);

        Task UpdateProduct(Product product);
    }
}
