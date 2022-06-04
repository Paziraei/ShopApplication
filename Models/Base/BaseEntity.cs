namespace Models.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
        }

        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string Discription { get; set; }
        public bool IsDeleted { get; set; }


    }
}
