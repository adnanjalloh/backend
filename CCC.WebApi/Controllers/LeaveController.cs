using CCC.Common.Action;
using CCC.Dto.Request.Leave;
using CCC.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CCC.WebApi.Controllers
{
    [Route("api/leave")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveService _leaveService;

        public LeaveController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }
        
        [HttpGet("get-all-leave-types")] 
        public async Task<IActionResult> GetAllLeaveType()
        {
            return Ok(await _leaveService.GetAllLeaveType());
        }

        [HttpPost("search-leave")]
        public async Task<IActionResult> SearchLeave(Query<SearchLeaveRequestDto> query)
        {
            return Ok(await _leaveService.SearchLeave(query));
        }


        [HttpPost("create-leave")]
        public async Task<IActionResult> CreateLeave()
        {
            return Ok(await _leaveService.CreateLeave());
        }

        [HttpPatch("update-leave")]
        public async Task<IActionResult> UpdateLeave(CreateLeaveRequestDto requestDto)
        {
            return Ok(await _leaveService.UpdateLeave(requestDto));
        }

        [HttpPost("create-leave-type")]
        public async Task<IActionResult> CreateLeaveType(CreateLeaveTypeRequestDto requestDto)
        {
            return Ok(await _leaveService.CreateLeaveType(requestDto));
        }

        [HttpDelete("delete-leave")]
        public async Task<IActionResult> DeleteLeave(int id)
        {
            return Ok(await _leaveService.DeleteLeave(id));
        }
    }
}
