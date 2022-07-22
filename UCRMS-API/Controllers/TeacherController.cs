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

        [HttpGet("departmentwise")]
        public async Task<ActionResult<List<Teacher>>> GetTeachersByDept(int deptId)
        {
            try
            {
                var response = _teacherService.GetTeachersByDeptId(deptId);
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("remainingcredit")]
        public async Task<ActionResult<List<double>>> GetRemainingCreditByTeacher(int teacherId)
        {
            try
            {
                var response = _teacherService.GetRemainingCreditByTeacherId(teacherId);
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddTeacher([FromBody] Teacher teacher)
        {
            try
            {
                var res = _teacherService.AddTeacher(teacher);
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
