using CCC.Common.Action;
using CCC.Dto.Request.Expense;
using CCC.Dto.Response.Expense;

namespace CCC.Service.Interface
{
    public interface IExpenseClaimService
    {
        Task<PaggingOperationResult<SearchExpenseClaimResponseDto>> SearchExpenseClaim(Query<SearchExpenseClaimRequestDto> query);
        Task<PaggingOperationResult<GetClaimDetailsResponseDto>> GetClaimDetails(Query<GetClaimDetailsRequestDto> query);
        Task<OperationResult<CreateClaimResponseDto>> CreateClaim();
        Task<OperationResult<CreateClaimResponseDto>> UpdateClaim(CreateClaimRequestDto requestDto);
        Task<OperationResult<CreateClaimDetailsResponseDto>> UpdateClaimDetail(CreateClaimDetailsRequestDto requestDto);
        Task<OperationResult<CreateClaimDetailsResponseDto>>CreateClaimDetail();
        Task<OperationResult<string>> GetClaimTitle(int id);
    }
}
