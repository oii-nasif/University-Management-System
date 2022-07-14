using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UCRMS_API.Data;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace UCRMS_API.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class CourseController : BaseController//ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetList()
        {
            try
            {
                var response = _courseService.GetList();
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

      /*  [HttpPost]
        public async Task<ActionResult<List<Course>>> AddCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return Ok(await _context.Courses.ToListAsync());
        }*/
    }
}