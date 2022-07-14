using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UCRMS_API.Data;
using UCRMS_API.Models;

namespace UCRMS_API.Controllers
{
    public class DepartmentController : BaseController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetList()
        {
            try
            {
                var response = _departmentService.GetList();
                if (response != null) return Ok(response);
                else return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        /*[HttpPost]
        public async Task<ActionResult<List<Department>>> AddDepartment(Department dept)
        {
            _departmentService.Add(dept);
            await _context.SaveChangesAsync();
            return Ok(await _context.Departments.ToListAsync());
        }*/
    } 
}
