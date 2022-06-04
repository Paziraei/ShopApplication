using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Order : Base.BaseEntity
    {
        public Order()
        {
        }

        [MaxLength(50)]
        public string? Status { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
       
    }
}
