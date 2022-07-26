using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UCRMS_API.Model;

namespace UCRMS_API.Controllers
{
    public class SemesterController : BaseController
    {
        private readonly ISemesterService _semeseterService;

        public SemesterController(ISemesterService semesterService)
        {
            _semeseterService = semesterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Semester>>> GetList()
        {
            try
            {
                var response = _semeseterService.GetList();
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("semesterName")]
        public async Task<ActionResult<List<string>>> GetSemesterById(int semesterId)
        {
            try
            {
                var response = _semeseterService.GetSemesterName(semesterId);
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
