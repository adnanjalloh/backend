using CCC.Common.Action;
using CCC.Dto.Request.Employee;
using CCC.Dto.Response.Employee;

namespace CCC.Service.Interface
{
    public interface IEmployeeService
    {
        Task<PaggingOperationResult<GetAllEmployeeResponseDto>> GetAllEmployees(Query query);
        Task<OperationResult<CreateEmployeeResponseDto>> CreateEmployee();
        Task<OperationResult<UpdateEmployeeResponseDto>> UpdateEmployee(UpdateEmployeeRequestDto requestDto);
        Task<OperationResult> DeleteEmployee(int employeeId);
    }
}
