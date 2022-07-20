using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UCRMS_API.Model;

namespace UCRMS_API.Controllers
{
    public class DesignationController : BaseController
    {
        private readonly IDesignationService _designationService;

        public DesignationController(IDesignationService designationService)
        {
            _designationService = designationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Designation>>> GetList()
        {
            try
            {
                var response = _designationService.GetList();
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
