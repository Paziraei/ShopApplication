using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class ProductBasket : Base.BaseEntity
    {
        public ProductBasket()
        {
        }

        
        public Basket? Basket { get; set; }
        public int? BasketId { get; set; }

        public Basket? NextBasket { get; set; }
        public int? NextBasketId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }


        public int Count { get; set; }
        public int TotalPrice { get; set; }
    }
}
