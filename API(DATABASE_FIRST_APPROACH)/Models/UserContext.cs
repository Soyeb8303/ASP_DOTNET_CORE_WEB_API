using Microsoft.EntityFrameworkCore;

namespace API_DATABASE_FIRST_APPROACH_.Models
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Employee> Employee { get; set; }



    }
}
