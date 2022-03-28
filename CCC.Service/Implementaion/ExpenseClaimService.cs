using AutoMapper;
using CCC.Common.Action;
using CCC.Common.Util.Result;
using CCC.Common.Util.Validation;
using CCC.Data.Model;
using CCC.Dto.Request.Expense;
using CCC.Dto.Response.Expense;
using CCC.Repository.Interface;
using CCC.Service.Interface;

namespace CCC.Service.Implementaion
{
    public class ExpenseClaimService : IExpenseClaimService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IExpenseClaimDetailRepository _expenseClaimDetailRepository;
        private readonly IExpenseClaimRepository _expenseClaimRepository;
        private readonly IMapper _mapper;
        public ExpenseClaimService(IEmployeeRepository employeeRepository,
            IExpenseClaimDetailRepository expenseClaimDetailRepository,
            IExpenseClaimRepository expenseClaimRepository,
            IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _expenseClaimDetailRepository = expenseClaimDetailRepository;
            _expenseClaimRepository = expenseClaimRepository;
            _mapper = mapper;
        }

        public async Task<OperationResult<CreateClaimResponseDto>> UpdateClaim(CreateClaimRequestDto requestDto)
        {
            var result = new OperationResult<CreateClaimResponseDto>();
            try
            {
                result.ValidationResults(requestDto);
                if (result.Errors.Any())
                    return result;

                var getEmployeeResult = await _employeeRepository.GetAsync(x => x.EmployeeId == requestDto.EmployeeId);
                if (!getEmployeeResult.Result)
                {
                    result.MapValues(getEmployeeResult);
                    return result;
                }

                var dbExpenseClaim = _mapper.Map<ExpenseClaim>(requestDto);
                var dbExpenseClaimResult = await _expenseClaimRepository.GetAsync(x => x.ExpenseClaimId == requestDto.ExpenseClaimId);
                var dbUpdatingResult = new OperationResult<ExpenseClaim>();
                if (!dbExpenseClaimResult.Result)
                {
                    dbUpdatingResult = await _expenseClaimRepository.AddAsync(dbExpenseClaim);
                }
                else
                {
                    dbUpdatingResult = await _expenseClaimRepository.UpdateAsync(dbExpenseClaim);
                }

                result.MapValues(dbUpdatingResult);

                if (dbUpdatingResult.Response is not null)
                    result.Response = _mapper.Map<CreateClaimResponseDto>(dbUpdatingResult.Response);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult<List<CreateClaimDetailsResponseDto>>> CreateClaimDetails(List<CreateClaimDetailsRequestDto> requestDto)
        {
            var result = new OperationResult<List<CreateClaimDetailsResponseDto>>();
            try
            {
                result.ValidationResults(requestDto);
                if (result.Errors.Any())
                    return result;

                if (requestDto is null)
                    return result;


                var claimId = requestDto.FirstOrDefault().ExpenseClaimId;

                var getClaimResult = await _expenseClaimRepository.GetAsync(x => x.ExpenseClaimId == claimId);

                if (!getClaimResult.Result)
                {
                    result.PrepareNotFoundResult("Expense Claim not found");
                    return result;
                }


                var dbExpenseClaimDetails = _mapper.Map<List<ExpenseClaimDetail>>(requestDto);

                var dbCreationResult = new List<ExpenseClaimDetail>();
                foreach (var item in dbExpenseClaimDetails)
                {
                    var data = await _expenseClaimDetailRepository.AddAsync(item);
                    dbCreationResult.Add(data.Response);
                    
                }

                //Update Total
                var total = dbCreationResult.Select(x => x.Total).Sum();
                getClaimResult.Response.Total = total;
                getClaimResult = await _expenseClaimRepository.UpdateAsync(getClaimResult.Response);


                if (dbCreationResult is not null)
                    result.Response = _mapper.Map<List<CreateClaimDetailsResponseDto>>(dbCreationResult);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<PaggingOperationResult<GetClaimDetailsResponseDto>> GetClaimDetails(Query<GetClaimDetailsRequestDto> query)
        {
            var result = new PaggingOperationResult<GetClaimDetailsResponseDto>();
            try
            {
                if (query is null)
                {
                    result.PrepareMissingParameterResult("");
                    return result;
                }

                result.ValidationResults(query.Parameter);
                if (result.Errors.Any())
                    return result;

                var dbResult = await _expenseClaimDetailRepository.GetListAsync(x => x.ExpenseClaimId == query.Parameter.ClaimId);

                result.MapValues(dbResult);

                if (dbResult.Response is not null)
                    result.Response = _mapper.Map<List<GetClaimDetailsResponseDto>>(dbResult.Response);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<PaggingOperationResult<SearchExpenseClaimResponseDto>> SearchExpenseClaim(Query<SearchExpenseClaimRequestDto> query)
        {
            var result = new PaggingOperationResult<SearchExpenseClaimResponseDto>();
            try
            {
                if (query is null)
                {
                    result.PrepareMissingParameterResult("");
                    return result;
                }

                result.ValidationResults(query.Parameter);
                if (result.Errors.Any())
                    return result;

               var dbResult = await _expenseClaimRepository.GetListAsync(x => x.EmployeeId == query.Parameter.EmployeeId, includeExpression: "Employee");

                result.MapValues(dbResult);

                if (dbResult.Response is not null)
                    result.Response = _mapper.Map<List<SearchExpenseClaimResponseDto>>(dbResult.Response);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult<CreateClaimResponseDto>> CreateClaim()
        {
            var result = new OperationResult<CreateClaimResponseDto>();
            try
            {
                Random rnd = new();

                result.Response = new CreateClaimResponseDto
                {
                    ExpenseClaimId = rnd.Next(1, int.MaxValue),
                    Description = "A New Expense"
                };
                result.Result = true;
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }
    }
}
