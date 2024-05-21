using System.ComponentModel.DataAnnotations;

namespace API_DATABASE_FIRST_APPROACH_.Models
{
    public class Employee
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }

        public string Education { get; set; }
    }
}
