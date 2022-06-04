using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Category : Base.BaseEntity
    {
        public Category()
        {    
        }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public List<Product>  Products { get; set; }
        public List<SaleDiscount> SaleDiscounts { get; set; }

        //public List<Prodact> ProdactsId { get; set; }
    }
}
