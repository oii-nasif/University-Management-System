using BusinessLayer.Interfaces;
using Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class ViewResultVMController : BaseController
    {
        private readonly IViewResultVMService _viewResultVMService;

        public ViewResultVMController(IViewResultVMService viewResultVMService)
        {
            _viewResultVMService = viewResultVMService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewResultVM>>> GetList(int studentId)
        {
            try
            {
                var response = _viewResultVMService.GetStudentResult(studentId);
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
