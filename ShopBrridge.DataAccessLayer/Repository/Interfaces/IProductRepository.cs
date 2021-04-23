using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBrridge.DataAccessLayer
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();

        Task<int> AddProduct(Product product);

        Task<int> DeleteProduct(int product);

        Task UpdateProduct(Product product);
    }
}
