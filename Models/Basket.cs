using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Basket : Base.BaseEntity
    {
        public Basket()
        {
        }
        
        public User User { get; set; }
        public int UserId { get; set; }

        
        public List<ProductBasket> ProductBaskets { get; set; }
        
        public List<ProductBasket> NextProductBaskets { get; set; }
    }
}
