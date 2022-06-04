using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Address : Base.BaseEntity
    {
        public Address()
        {
        }
      [Required]
        public string Text { get; set; }

        
        public City?  City { get; set; }
        public int? CityId { get; set; }

        public string? CodePost { get; set; }

       
        public User User { get; set; }
        public int UserId { get; set; }
        
        //public Product Product { get; set; }
        
        //public int ProductId { get; set; }
    }
}
