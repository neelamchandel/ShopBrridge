using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopBrridge.BusinessLayer.Interfaces;
using ShopBrridge.DataAccessLayer;

namespace ShopBrridge.BusinessLayer
{
    public class ProductsService /*: IProductsService*/
    {
        IProductRepository _productRepository;

        public ProductsService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
         
        public IEnumerable<Product> GetProductByProductId(int productId)
        {
            return _productRepository.GetAllProducts().Where(x => x.ProductId == Product).ToList();
        }
         
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return _productRepository.GetAllProducts().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public Product GetProductByroductName(string productName)
        {
            return _productRepository.GetAll().Where(x => x.ProductId == productId).FirstOrDefault();
        }
          
        public async Task<Product> AddProduct(Product product)
        {
            return await _productRepository.AddProductAsync(product);
        }
          
        public bool DeleteProduct(string productId)
        {

            try
            {
                var DataList = _productRepository.GetAllProducts().Where(x => x.UserEmail == UserEmail).ToList();
                foreach (var item in DataList)
                {
                    _productRepository.DeleteProduct(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }
        //Update Person Details  
        public bool UpdatePerson(Person person)
        {
            try
            {
                var DataList = _person.GetAll().Where(x => x.IsDeleted != true).ToList();
                foreach (var item in DataList)
                {
                    _person.Update(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}   
}
