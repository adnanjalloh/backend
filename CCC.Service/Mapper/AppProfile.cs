using AutoMapper;
using CCC.Dto.Request.Employee;
using CCC.Dto.Request.Expense;
using CCC.Dto.Request.Leave;
using CCC.Dto.Response.Employee;
using CCC.Dto.Response.Expense;
using CCC.Dto.Response.Leave;
using CCC.Data.Model;

namespace CCC.Service.Mapper
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<CreateClaimDetailsRequestDto, ExpenseClaimDetail >();
            CreateMap<ExpenseClaimDetail, CreateClaimDetailsResponseDto>();
            CreateMap<CreateClaimRequestDto, ExpenseClaim>();
            CreateMap<ExpenseClaim, CreateClaimResponseDto>();

            CreateMap<ExpenseClaim, SearchExpenseClaimResponseDto>()
                .ForMember(dest => dest.EmployeeTitle, act => act.MapFrom(src => src.Employee.Name));

            CreateMap<ExpenseClaimDetail, GetClaimDetailsResponseDto>();
            CreateMap<CreateEmployeeRequestDto, Employee >();
            CreateMap<Employee, CreateEmployeeResponseDto>();
            CreateMap<UpdateEmployeeRequestDto, Employee>();
            CreateMap<Employee, UpdateEmployeeResponseDto>();

            CreateMap<Employee, GetAllEmployeeResponseDto>()
                .ForMember(dest => dest.DepartmentTitle, act => act.MapFrom(src => src.Department.Title));


            CreateMap<Department, GetAllDepartmentResponseDto>();
            CreateMap<CreateLeaveRequestDto, Leave>();


            CreateMap<Leave, SearchLeaveResponseDto>()
                .ForMember(dest => dest.EmployeeTitle, act => act.MapFrom(src => src.Employee.Name))
                .ForMember(dest => dest.LeaveTypeTitle, act => act.MapFrom(src => src.LeaveType.Title));

            CreateMap<Leave, CreateLeaveResponseDto>();
            CreateMap<CreateLeaveTypeRequestDto,LeaveType>();
            CreateMap<LeaveType, CreateLeaveTypeResponseDto>();
            CreateMap<LeaveType, GetAllLeaveTypeResponseDto>();

        }
    }
}
