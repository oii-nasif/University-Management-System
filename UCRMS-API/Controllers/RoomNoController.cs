using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class RoomNoController : BaseController
    {
        private readonly IRoomNoService _roomNoService;

        public RoomNoController(IRoomNoService roomNoService)
        {
            _roomNoService = roomNoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomNo>>> GetList()
        {
            try
            {
                var response = _roomNoService.GetList();
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
