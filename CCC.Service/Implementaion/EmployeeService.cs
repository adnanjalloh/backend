using AutoMapper;
using CCC.Common.Action;
using CCC.Common.Util.Result;
using CCC.Common.Util.Validation;
using CCC.Data.Model;
using CCC.Dto.Request.Employee;
using CCC.Dto.Response.Employee;
using CCC.Repository.Interface;
using CCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace CCC.Service.Implementaion
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository,
            IMapper mapper,
            IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }

        public async Task<OperationResult<CreateEmployeeResponseDto>> CreateEmployee()
        {
            var result = new OperationResult<CreateEmployeeResponseDto>();
            try
            {
                Random rnd = new();

                result.Response = new CreateEmployeeResponseDto
                {
                    EmployeeId = rnd.Next(1, int.MaxValue),
                    Name = "A New Employee"
                };
                result.Result = true;
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult> DeleteEmployee(int employeeId)
        {
            var result = new OperationResult();
            try
            {
                var deletedResult = await _employeeRepository.DeleteAsync(new Employee { EmployeeId = employeeId });
                result.MapValues(deletedResult);
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<PaggingOperationResult<GetAllEmployeeResponseDto>> GetAllEmployees(Query query)
        {
            var result = new PaggingOperationResult<GetAllEmployeeResponseDto>();
            try
            {
                var dbResult = await _employeeRepository.GetListAsync(query: query, includeExpression: "Department");

                if (dbResult.Response is not null)
                    result.Response = _mapper.Map<List<GetAllEmployeeResponseDto>>(dbResult.Response);

                result.MapValues(dbResult);
                result.Result = true;
            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }

        public async Task<OperationResult<UpdateEmployeeResponseDto>> UpdateEmployee(UpdateEmployeeRequestDto requestDto)
        {
            var result = new OperationResult<UpdateEmployeeResponseDto>();
            try
            {
                result.ValidationResults(requestDto);
                if (result.Errors.Any())
                    return result;

                var dbDepartmentResult = await _departmentRepository.GetAsync(x => x.DepartmentId == requestDto.DepartmentId);
                if (!dbDepartmentResult.Result)
                {
                    result.PrepareNotFoundResult("Department not found.");
                    return result;
                }

                var dbEmployee = _mapper.Map<Employee>(requestDto);

                var dbUpdatingResult = new OperationResult<Employee>();

                var dbEmployeeResult = await _employeeRepository.GetAsync(x => x.EmployeeId == requestDto.EmployeeId);

                if (!dbEmployeeResult.Result)
                {
                    dbUpdatingResult = await _employeeRepository.AddAsync(dbEmployee);
                }
                else
                {
                    dbUpdatingResult = await _employeeRepository.UpdateAsync(dbEmployee);
                }

                result.MapValues(dbUpdatingResult);

                if (dbUpdatingResult.Response is not null)
                    result.Response = _mapper.Map<UpdateEmployeeResponseDto>(dbUpdatingResult.Response);

            }
            catch (Exception ex)
            {
                result.PrepareExceptionResult(ex);
            }
            return result;
        }
    }
}
