using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UCRMS_API.Data;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace UCRMS_API.Controllers
{
    public class CourseController : BaseController
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

        [HttpGet("departmentwise")]
        public async Task<ActionResult<List<Course>>> GetDepartmentwiseList(int deptId)
        {
            try
            {
                var response = _courseService.GetDepartmentwiseList(deptId);
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddCourse([FromBody] Course course)
        {
            try
            {
                var res = _courseService.AddCourse(course);
                if (res) return Ok(res);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


    }
}