using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopBrridge.DataAccessLayer;

namespace ShopBrridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productRepository.GetAllProducts();
                if (products == null)
                {
                    return NotFound();
                }

                return Ok(products);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var productId = await _productRepository.AddProduct(product);
                    if (productId > 0)
                    {
                        return Ok(productId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            int result;
            try
            {
                result = await _productRepository.DeleteProduct(productId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _productRepository.UpdateProduct(product);
                    return Ok();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return BadRequest();
        }

    }
}
