using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class GradeLetterController : BaseController
    {
        private readonly IGradeLetterService _gradeLetterService;

        public GradeLetterController(IGradeLetterService gradeLetterService)
        {
            _gradeLetterService = gradeLetterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GradeLetter>>> GetList()
        {
            try
            {
                var response = _gradeLetterService.GetList();
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
