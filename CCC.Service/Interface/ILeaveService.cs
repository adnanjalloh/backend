using CCC.Common.Action;
using CCC.Dto.Request.Leave;
using CCC.Dto.Response.Leave;

namespace CCC.Service.Interface
{
    public interface ILeaveService
    {

        Task<PaggingOperationResult<GetAllLeaveTypeResponseDto>> GetAllLeaveType();

        Task<PaggingOperationResult<SearchLeaveResponseDto>> SearchLeave(Query<SearchLeaveRequestDto> query);

        Task<OperationResult<CreateLeaveResponseDto>> CreateLeave();
        Task<OperationResult<CreateLeaveResponseDto>> UpdateLeave(CreateLeaveRequestDto createLeaveRequestDto);

        Task<OperationResult<CreateLeaveTypeResponseDto>> CreateLeaveType(CreateLeaveTypeRequestDto requestDto);
        Task<OperationResult> DeleteLeave(int leaveId);
    }
}
