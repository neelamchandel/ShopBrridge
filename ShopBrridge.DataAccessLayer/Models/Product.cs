using System.ComponentModel.DataAnnotations;

namespace ShopBrridge.DataAccessLayer
{
    public partial class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}

