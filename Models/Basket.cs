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

        
        public List<ProdactBasket> ProdactBaskets { get; set; }
        
        public List<ProdactBasket> NextProdactBaskets { get; set; }
    }
}
