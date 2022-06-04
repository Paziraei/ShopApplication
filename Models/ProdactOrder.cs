using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class ProdactOrder : Base.BaseEntity
    {
        public ProdactOrder()
        {
        }

        public Product Prodact { get; set; }
        public int ProdactId { get; set; }

        public int Count { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }

        public int TotalPrice { get; set; }
    }
}
