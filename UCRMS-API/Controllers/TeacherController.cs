using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UCRMS_API.Model;

namespace UCRMS_API.Controllers
{
    public class TeacherController : BaseController
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Teacher>>> GetList()
        {
            try
            {
                var response = _teacherService.GetList();
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
