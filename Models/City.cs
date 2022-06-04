using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class City : Base.BaseEntity
    {
        public City()
        {
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
       
        public State State { get; set; }
        
        public int StateId { get; set; }
    }
}
