using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class User : Base.BaseEntity
    {
        public User()
        {
        }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string NationalCode { get; set; }

        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(400)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public List<Product> Products { get; set; }

        public List< Address> Addresses{ get; set; }
      
        public List<Basket> Basket { get; set; }
        
    }
}
