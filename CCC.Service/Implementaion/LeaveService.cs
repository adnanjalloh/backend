using AutoMapper;
using CCC.Common.Action;
using CCC.Common.Util.Result;
using CCC.Common.Util.Validation;
using CCC.Data.Model;
using CCC.Dto.Request.Leave;
using CCC.Dto.Response.Leave;
using CCC.Repository.Interface;
using CCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace CCC.Service.Implementaion
{
    public class LeaveService : ILeaveService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly ILeaveRepository _leaveRepository;
        private readonly IMapper _mapper;

        public LeaveService(IEmployeeRepository employeeRepository,
            ILeaveTypeRepository leaveTypeRepository,
            ILeaveRepository leaveRepository,
            IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _leaveRepository = leaveRepository;
            _mapper = mapper;
        }

        public async Task<OperationResult<CreateLeaveResponseDto>> UpdateLeave(CreateLeaveRequestDto createLeaveRequest)
        {
            var result = new OperationResult<CreateLeaveResponseDto>(); 
            try
            {
                result.ValidationResults(createLeaveRequest);
                if (result.Errors.Any())
                    return result;

                if (createLeaveRequest.To < createLeaveRequest.From)
                {
                    result.Errors.Add(new Error { ErrorMessage = "To Date must bigger than From Date" });
                    return result;
                }
                var getEmployeeResult = await _employeeRepository.GetAsync(x => x.EmployeeId == createLeaveRequest.EmployeeId);
                if (!getEmployeeResult.Result)
                {
                    result.MapValues(getEmployeeResult);
                    return result;
                }
                var getLeaveTypeResult = await _leaveTypeRepository.GetAsync(x => x.LeaveTypeId == createLeaveRequest.LeaveTypeId);
                if (!getLeaveTypeResult.Result)
                {
                    result.PrepareNotFoundResult("Leave type not found.");
                    return result;
                }

                var dbLeave = _mapper.Map<Leave>(createLeaveRequest);
                var dbLeaveResult = await _leaveRepository.GetAsync(x => x.LeaveId == createLeaveRequest.LeaveId);
                var dbUpdatingResult = new OperationResult<Leave>();
                if (!dbLeaveResult.Result)
                {
                    dbUpdatingResult = await _leaveRepository.AddAsync(dbLeave);
                }
                else
                {
                    dbUpdatingResult = await _leaveRepository.UpdateAsync(dbLeave);
                }

                result.MapValues(dbUpdatingResult);

                if (dbUpdatingResult.Response is not null)
                    result.Response = _mapper.Map<CreateLeaveResponseDto>(dbUpdatingResult.Response);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult<CreateLeaveResponseDto>> CreateLeave()
        {
            var result = new OperationResult<CreateLeaveResponseDto>();
            try
            {
                Random rnd = new();

                result.Response = new CreateLeaveResponseDto
                {
                    LeaveId = rnd.Next(1, int.MaxValue),
                    Note = "A New Leave Note"
                };
                result.Result = true;
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult<CreateLeaveTypeResponseDto>> CreateLeaveType(CreateLeaveTypeRequestDto requestDto)
        {
            var result = new OperationResult<CreateLeaveTypeResponseDto>();
            try
            {
                result.ValidationResults(requestDto);
                if (result.Errors.Any())
                    return result;

                var dbLeaveType = _mapper.Map<LeaveType>(requestDto);

                var dbCreationResult = await _leaveTypeRepository.AddAsync(dbLeaveType);

                result.MapValues(dbCreationResult);

                if (dbCreationResult.Response is not null)
                    result.Response = _mapper.Map<CreateLeaveTypeResponseDto>(dbCreationResult.Response);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<PaggingOperationResult<GetAllLeaveTypeResponseDto>> GetAllLeaveType()
        {
            var result = new PaggingOperationResult<GetAllLeaveTypeResponseDto>();
            try
            {
                var dbQuery = _leaveTypeRepository.GetAll();
                var dbResult = await dbQuery.ToListAsync();

                if (dbResult is not null)
                    result.Response = _mapper.Map<List<GetAllLeaveTypeResponseDto>>(dbResult);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<PaggingOperationResult<SearchLeaveResponseDto>> SearchLeave(Query<SearchLeaveRequestDto> query)
        {
            var result = new PaggingOperationResult<SearchLeaveResponseDto>();
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

                if (query.Parameter.To < query.Parameter.From)
                {
                    result.Errors.Add(new Error { ErrorMessage = "To Date must bigger than From Date" });
                    return result;
                }

                var dbResult = new PaggingOperationResult<Leave>();
                if (query.Parameter.EmployeeId > 0)
                {
                    dbResult = await _leaveRepository.GetListAsync(x => x.To < query.Parameter.To && x.From >= query.Parameter.From && x.EmployeeId == query.Parameter.EmployeeId, query: query, includeExpression: "Employee; LeaveType");
                }
                else
                {
                    dbResult = await _leaveRepository.GetListAsync(x => x.To < query.Parameter.To && x.From >= query.Parameter.From, query: query, includeExpression: "Employee; LeaveType");
                }

                result.MapValues(dbResult);

                if (dbResult.Response is not null)
                    result.Response = _mapper.Map<List<SearchLeaveResponseDto>>(dbResult.Response);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult> DeleteLeave(int leaveId)
        {
            var result = new OperationResult();
            try
            {
                var deletedResult = await _leaveRepository.DeleteAsync(new Leave { LeaveId = leaveId });
                result.MapValues(deletedResult);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }
    }
}
