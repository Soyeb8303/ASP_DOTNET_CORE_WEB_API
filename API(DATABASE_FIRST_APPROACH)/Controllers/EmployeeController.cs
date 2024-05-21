using API_DATABASE_FIRST_APPROACH_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DATABASE_FIRST_APPROACH_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly UserContext context;

        public EmployeeController(UserContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployee()
        {
            var data = await context.Employee.ToListAsync();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> GetEmployeeById(int id)
        {
            var emp = await context.Employee.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

    }
}
