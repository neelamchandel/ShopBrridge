using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopBrridge.DataAccessLayer;

namespace ShopBrridge.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ShopBridgeDBContext _shopBridgeDBContext;

        public ProductRepository(ShopBridgeDBContext shopBridgeDBContext)
        {
            _shopBridgeDBContext = shopBridgeDBContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            if (_shopBridgeDBContext != null)
            {
                return await _shopBridgeDBContext.Products.ToListAsync();
            }
            return null;
        }

        public async Task<int> AddProduct(Product product)
        {
            if (_shopBridgeDBContext != null)
            {
                await _shopBridgeDBContext.Products.AddAsync(product);
                await _shopBridgeDBContext.SaveChangesAsync();
                return product.ProductId;
            }
            return 0;
        }

        public async Task<int> DeleteProduct(int productId)
        {
            int result = 0;

            if (_shopBridgeDBContext != null)
            {
                //Find the product for specific product id
                var product = await _shopBridgeDBContext.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
                if (product != null)
                {
                    //Delete that product
                    _shopBridgeDBContext.Products.Remove(product);
                    //Commit the transaction
                    result = await _shopBridgeDBContext.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }

        public async Task UpdateProduct(Product product)
        {
            if (_shopBridgeDBContext != null)
            {
                //Delete that product
                _shopBridgeDBContext.Products.Update(product);
                //Commit the transaction
                await _shopBridgeDBContext.SaveChangesAsync();
            }
        }
    }
}
