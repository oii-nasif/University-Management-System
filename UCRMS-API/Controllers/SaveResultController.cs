using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class SaveResultController : BaseController
    {
        private readonly ISaveResultService _saveResultService;
        public SaveResultController(ISaveResultService saveResultService)
        {
            _saveResultService = saveResultService;
                
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
