using API_DATABASE_FIRST_APPROACH_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DATABASE_FIRST_APPROACH_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

      
        private readonly UserContext context;

        public UsersController(UserContext context)
        {
            this.context = context;
        }

    

        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetStudents()
        {
            var data = await context.Users.ToListAsync();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Users>>> GetStudentById(int id)
        {
            var student = await context.Users.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }


        [HttpPost]
        public async Task<ActionResult<Users>> CreateStudent(Users std)
        {
            await context.Users.AddAsync(std);
            await context.SaveChangesAsync();
            return Ok(std);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Users>> UpdateStudent(int id, Users std)
        {
            if (id != std.ID)
            {
                return BadRequest();
            }
            context.Entry(std).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> DeleteStudent(int id)
        {
            var std = await context.Users.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            context.Users.Remove(std);
            await context.SaveChangesAsync();
            return Ok();
        }



    }
}
