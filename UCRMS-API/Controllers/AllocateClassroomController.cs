using BusinessLayer.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UCRMS_API.Controllers
{
    public class AllocateClassroomController : BaseController
    {
        private readonly IAllocateClassroomService _allocateClassroomService;

        public AllocateClassroomController(IAllocateClassroomService allocateClassroomService)
        {
            _allocateClassroomService = allocateClassroomService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AllocateNewClassroom([FromBody] AllocateClassroom allocateClassroom)
        {
            try
            {
                var res = _allocateClassroomService.AllocateNewClassroom(allocateClassroom);
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
