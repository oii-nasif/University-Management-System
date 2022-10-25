using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class CourseAssignmentController : BaseController
    {
        private readonly ICourseAssignmentService _courseAssignmentService;

        public CourseAssignmentController(ICourseAssignmentService courseAssignmentService)
        {
            _courseAssignmentService = courseAssignmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseAssignment>>> GetList()
        {
            try
            {
                var response = _courseAssignmentService.GetList();
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddCourse([FromBody] CourseAssignment courseAssignment)
        {
            try
            {
                var res = _courseAssignmentService.AddCourseAssignment(courseAssignment);
                if (res) return Ok(res);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("unassign_courses")]
        public async Task<ActionResult<bool>> UnassignCourses()
        {
            try
            {
                var response = _courseAssignmentService.UnassignAllCourses();
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
