using CCC.Common.Action;
using CCC.Dto.Response.Employee;

namespace CCC.Service.Interface
{
    public interface IDepartmentService
    {
        Task<PaggingOperationResult<GetAllDepartmentResponseDto>> GetAllDepartments();
    }
}
