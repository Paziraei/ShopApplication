using System.ComponentModel.DataAnnotations;using System.ComponentModel.DataAnnotations;
namespace Models
{
	public class State : Base.BaseEntity
    {
        public State()
        {
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

       
        public List<City> Cities { get; set; }

    }
}
