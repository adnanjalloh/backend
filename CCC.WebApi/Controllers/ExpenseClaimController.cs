using CCC.Common.Action;
using CCC.Dto.Request.Expense;
using CCC.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CCC.WebApi.Controllers
{
    [Route("api/expense")]
    [ApiController]
    public class ExpenseClaimController : ControllerBase
    {
        private readonly IExpenseClaimService _expenseClaimService;

        public ExpenseClaimController(IExpenseClaimService expenseClaimService)
        {
            _expenseClaimService = expenseClaimService;
        }

        [HttpPost("search-expense-claim")]
        public async Task<IActionResult> SearchExpenseClaim(Query<SearchExpenseClaimRequestDto> query)
        {
            return Ok(await _expenseClaimService.SearchExpenseClaim(query));
        }

        [HttpPost("get-expense-claim-details")]
        public async Task<IActionResult> GetClaimDetails(Query<GetClaimDetailsRequestDto> query)
        {
            return Ok(await _expenseClaimService.GetClaimDetails(query));
        }

        [HttpPatch("update-expense-claim")]
        public async Task<IActionResult> CreateClaim(CreateClaimRequestDto requestDto)
        {
            return Ok(await _expenseClaimService.UpdateClaim(requestDto));
        }

        [HttpPost("create-expense-claim")]
        public async Task<IActionResult> CreateClaim()
        {
            return Ok(await _expenseClaimService.CreateClaim());
        }

        [HttpPatch("update-expense-claim-detail")]
        public async Task<IActionResult> UpdateClaimDetail(CreateClaimDetailsRequestDto requestDto)
        {
            return Ok(await _expenseClaimService.UpdateClaimDetail(requestDto));
        }

        [HttpPost("create-expense-claim-detail")]
        public async Task<IActionResult> CreateClaimDetail()
        {
            return Ok(await _expenseClaimService.CreateClaimDetail());
        }

        [HttpGet("get-expense-title")]
        public async Task<IActionResult> GetExpenseTitle(int id)
        {
            return Ok(await _expenseClaimService.GetClaimTitle(id));
        }
    }
}
