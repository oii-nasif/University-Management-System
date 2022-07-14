using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UCRMS_API.Data;
using UCRMS_API.Models;

namespace UCRMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DataContext _context;

        public DepartmentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> Get()
        {
            return Ok(await _context.Departments.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Department>>> AddDepartment(Department dept)
        {
            _context.Departments.Add(dept);
            await _context.SaveChangesAsync();
            return Ok(await _context.Departments.ToListAsync());
        }
    }
}
