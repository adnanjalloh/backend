using CCC.Repository.ServiceFactory;
using CCC.Service.Implementaion;
using CCC.Service.Interface;
using CCC.Service.Mapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CCC.Service.ServiceFactory
{
    public static class Extenstions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILeaveService, LeaveService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IExpenseClaimService, ExpenseClaimService>();
            services.AddScoped<IDepartmentService, DepartmentService>();

            services.AddRepositories(configuration);

            //Profiles
            services.AddAutoMapper(x => {
                x.AddProfile<AppProfile>();
            });
        }
    }
}
