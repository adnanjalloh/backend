using CCC.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CCC.WebApi.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            ;
            _departmentService = departmentService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllDepartments()
        {
            return Ok(await _departmentService.GetAllDepartments());
        }
    }
}
