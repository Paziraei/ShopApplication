using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class ProdactBasket : Base.BaseEntity
    {
        public ProdactBasket()
        {
        }

        
        public Basket Basket { get; set; }
        public int BasketId { get; set; }

        public Product Prodact { get; set; }
        public int ProdactId { get; set; }

        public int Count { get; set; }
        public int TotalPrice { get; set; }
    }
}
