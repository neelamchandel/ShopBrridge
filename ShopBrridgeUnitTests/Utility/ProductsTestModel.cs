using ShopBrridge.DataAccessLayer;
using System.Collections.Generic;

namespace ShopBrridgeUnitTests.Utility
{
    public class ProductsTestModel
    {
        public List<Product> Products()
        {
            var products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Product 1", ProductDescription = "Product 1 is a very good product.", Price = 55.90m },
                new Product { ProductId = 2, ProductName = "Product 2", ProductDescription = "Product 2 is a very good product.", Price = 200.50m },
                new Product { ProductId = 3, ProductName = "Product 3", ProductDescription = "Product 3 is a very good product.", Price = 100.20m }
            };

            return products;
        }
    }
}
