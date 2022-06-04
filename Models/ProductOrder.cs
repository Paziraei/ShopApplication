using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class ProductOrder : Base.BaseEntity
    {
        public ProductOrder()
        {
        }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public int Count { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }

        public int TotalPrice { get; set; }
    }
}
