using BusinessLayer.Interfaces;
using Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class CourseStaticsVMController : BaseController
    {

        private readonly ICourseStaticsVMService _courseStaticsVMService;

        public CourseStaticsVMController(ICourseStaticsVMService courseStaticsVMService)
        {
            _courseStaticsVMService = courseStaticsVMService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseStaticsVM>>> GetList(int deptId)
        {
            try
            {
                var response = _courseStaticsVMService.GetCourseStatics(deptId);
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
