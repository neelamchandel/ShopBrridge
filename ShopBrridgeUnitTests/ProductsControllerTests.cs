using ShopBrridge.Controllers;
using ShopBrridge.DataAccessLayer;
using ShopBrridgeUnitTests.Utility;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ShopBrridgeUnitTests
{
    public class ProductsControllerTests
    {

        private readonly ProductsController _productsController = null;
        private readonly IProductRepository _productRepository = null;

        public ProductsControllerTests()
        {
            if (_productsController == null)
            {
                _productsController = new ProductsController(_productRepository);
            }
        }

        [Fact]
        public async Task GetAllProducts_ShouldReturnAllProducts()
        {
            var productsTestModel = new ProductsTestModel();
            var testProducts = productsTestModel.Products();

            var result = await _productsController.GetAllProducts() as List<Product>; ;
            Assert.Equal(testProducts.Count, result.Count);
        }
    }
}
