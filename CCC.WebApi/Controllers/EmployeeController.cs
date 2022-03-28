using CCC.Common.Action;
using CCC.Dto.Request.Employee;
using CCC.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CCC.WebApi.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("get-all-employees")]
        public async Task<IActionResult> GetAllEmployees(Query query)
        {
            return Ok(await _employeeService.GetAllEmployees(query));
        }

        [HttpPost("create-employee")]
        public async Task<IActionResult> CreateEmployee()
        {
            return Ok(await _employeeService.CreateEmployee());
        }

        [HttpPatch("update-employee")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeRequestDto requestDto)
        {
            return Ok(await _employeeService.UpdateEmployee(requestDto));
        }

        [HttpDelete("delete-employee")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            return Ok(await _employeeService.DeleteEmployee(id));
        }
    }
}
