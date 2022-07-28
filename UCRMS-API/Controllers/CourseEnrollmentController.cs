using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class CourseEnrollmentController : BaseController
    {
        private readonly ICourseEnrollmentService _courseEnrollmentService;

        public CourseEnrollmentController(ICourseEnrollmentService courseEnrollmentService)
        {
            _courseEnrollmentService = courseEnrollmentService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> CourseEnrollment([FromBody] CourseEnrollment courseEnrollment)
        {
            try
            {
                var res = _courseEnrollmentService.CourseEnrollment(courseEnrollment);
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
