using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class SaleDiscount:Base.BaseEntity
    {
        public SaleDiscount()
        {
        }
        
        public DateTime DateStart { get; set; }

        
        public DateTime? DateEnd { get; set; }

        
        public int Discont { get; set; }

        
        [MaxLength(10)]
        public string Code { get; set; }
        public Product? Product { get; set; }
        public int? ProductId { get; set; }

        public Category? Category { get; set; }
        public int? CategoryId { get; set; }
        public State? State { get; set; }
        public int StateId { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }        
        public int Order { get; set; }
    }
}
