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

        public User? User { get; set; }
        public int? UserId { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
        
        public List<ProductBasket> ProductBaskets { get; set; }


        public  Brand?  Brand { get; set; }
        public int? BrandId { get; set; }    
     
        public List<Gallery>? Galleries { get; set; }
        
        public List<SaleDiscount>? SaleDiscounts { get; set; }

    }
}
