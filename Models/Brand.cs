using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Brand : Base.BaseEntity
    {
        public Brand()
        {
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public byte[]? Logo { get; set; } 
        
        public Product Prodact { get; set; }
        public int ProdctId { get; set; }

    }
}
