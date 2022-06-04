using System.ComponentModel.DataAnnotations;
namespace Models
{
	public class Gallery : Base.BaseEntity
    {
        public Gallery()
        {
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }
        
       
        public Product Product { get; set; }
        
        public int ProdactId { get; set; }
    }
}
