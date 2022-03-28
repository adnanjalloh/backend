using AutoMapper;
using CCC.Common.Action;
using CCC.Common.Util.Result;
using CCC.Dto.Response.Employee;
using CCC.Repository.Interface;
using CCC.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace CCC.Service.Implementaion
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<PaggingOperationResult<GetAllDepartmentResponseDto>> GetAllDepartments()
        {
            var result = new PaggingOperationResult<GetAllDepartmentResponseDto>();
            try
            {

                var dbQuery = _departmentRepository.GetAll();
                var dbResult = await dbQuery.ToListAsync();

                if (dbResult is not null)
                    result.Response = _mapper.Map<List<GetAllDepartmentResponseDto>>(dbResult);

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
