using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Product :Base.BaseEntity
    {
        public Product()
        {   
        }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string BarCode { get; set; }
        [Required]
        public decimal Price { get; set; }
        
        public Category? Category { get; set; }
        public int? CategoryId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public List<ProdactOrder> ProdactOrders { get; set; }
        public List<ProdactOrder> ProdactOrderId { get; set; }
        public List<ProdactBasket> ProdactBaskets { get; set; }


        [Required]
        public Brand Brand { get; set; }

        [Required]
        public int BrandId { get; set; }
        public List<Gallery>? Galleries { get; set; }
        public List<Gallery>? GalleryId { get; set; }//?

        public List<SaleDiscount>? SaleDiscounts { get; set; }
        public List<SaleDiscount>? SaleDiscountId { get; set; }
    }
}
