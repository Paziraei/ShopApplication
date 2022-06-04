using System.ComponentModel.DataAnnotations;
namespace Models
{
	public class UserRole: Base.BaseEntity
	{
		public UserRole()
		{
		}
		
		public User User { get; set; }
        public int UserId { get; set; }
		
		public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
