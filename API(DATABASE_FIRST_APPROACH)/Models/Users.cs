using System.ComponentModel.DataAnnotations;

namespace API_DATABASE_FIRST_APPROACH_.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }


    }
}
