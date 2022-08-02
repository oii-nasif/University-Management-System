using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using UCRMS_API.Model;

namespace UCRMS_API.Controllers
{
    public class SaveResultController : BaseController
    {
        private readonly ISaveResultService _saveResultService;
        public SaveResultController(ISaveResultService saveResultService)
        {
            _saveResultService = saveResultService;
                
        }

        
        [HttpGet("courses_enrolled")]
        public async Task<ActionResult<List<Course>>> GetList(int studentId)
        {
            try
            {
                var response = _saveResultService.GetEnrolledCourses(studentId);
                if (response != null) return Ok(response);
                else return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public async Task<ActionResult<bool>> AddResult([FromBody] SaveResult saveResult)
        {
            try
            {
                var res = _saveResultService.AddResult(saveResult);

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
