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
                dbExpenseClaim.Date = DateTime.UtcNow;
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

        public async Task<OperationResult<CreateClaimDetailsResponseDto>> UpdateClaimDetail(CreateClaimDetailsRequestDto requestDto)
        {
            var result = new OperationResult<CreateClaimDetailsResponseDto>();
            try
            {
                result.ValidationResults(requestDto);
                if (result.Errors.Any())
                    return result;

                if (requestDto is null)
                    return result;


                var claimId = requestDto.ExpenseClaimId;

                var getClaimResult = await _expenseClaimRepository.GetAsync(x => x.ExpenseClaimId == claimId);

                if (!getClaimResult.Result)
                {
                    result.PrepareNotFoundResult("Expense Claim not found");
                    return result;
                }


                var dbExpenseClaimDetail = _mapper.Map<ExpenseClaimDetail>(requestDto);

                var dbGetExpenseClaimDetailResult = await _expenseClaimDetailRepository.GetAsync(x => x.ExpenseClaimDetailId == requestDto.ExpenseClaimDetailId);

                var dbUpdateingResult = new OperationResult<ExpenseClaimDetail>();

                if (dbGetExpenseClaimDetailResult.Result)
                {
                    dbUpdateingResult = await _expenseClaimDetailRepository.UpdateAsync(dbExpenseClaimDetail);
                }
                else
                {
                    dbUpdateingResult = await _expenseClaimDetailRepository.AddAsync(dbExpenseClaimDetail);
                }

                if (dbUpdateingResult.Result)
                {
                    //select details 

                    var dbDetails = _expenseClaimDetailRepository.GetAll(x => x.ExpenseClaimId == requestDto.ExpenseClaimId);


                    //Update Total
                    var total = dbDetails.Select(x => x.Total).Sum();

                    getClaimResult.Response.Total = total;
                    getClaimResult = await _expenseClaimRepository.UpdateAsync(getClaimResult.Response);

                    result.MapValues(getClaimResult);

                    if (dbUpdateingResult is not null)
                        result.Response = _mapper.Map<CreateClaimDetailsResponseDto>(dbUpdateingResult.Response);
                }
               
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

        public async Task<OperationResult<CreateClaimDetailsResponseDto>> CreateClaimDetail()
        {
            var result = new OperationResult<CreateClaimDetailsResponseDto>();
            try
            {
                Random rnd = new();

                result.Response = new CreateClaimDetailsResponseDto
                {
                    ExpenseClaimDetailId = rnd.Next(1, int.MaxValue),
                    Description = "A New Expense detail"
                };
                result.Result = true;
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult<string>> GetClaimTitle(int id)
        {
            var result = new OperationResult<string>();
            try
            {
                var dbResult = await _expenseClaimRepository.GetAsync(x => x.ExpenseClaimId == id);
                if (dbResult != null)
                {
                    result.Response = dbResult.Response.Description;
                    result.Result = true;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }
    }
}
