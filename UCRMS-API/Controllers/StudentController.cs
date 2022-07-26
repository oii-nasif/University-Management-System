using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class StudentController : BaseController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetList()
        {
            try
            {
                var response = _studentService.GetList();
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("CountByDept")]
        public async Task<ActionResult<List<double>>> CountByDeptId(int deptId)
        {
            try
            {
                var response = _studentService.GetStudentsNumberByDeptId(deptId);
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddStudent([FromBody] Student student)
        {
            try
            {
                var res = _studentService.AddStudent(student);

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
