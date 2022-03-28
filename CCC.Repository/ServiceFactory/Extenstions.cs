using CCC.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CCC.Common.Util.Sql;
using CCC.Repository.Interface;
using CCC.Repository.Implementaion;

namespace CCC.Repository.ServiceFactory
{
    public static class Extenstions
    {
        public static void AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddNpgSqlContext<AppDbContext>("Db-Conn-CCC", configuration);

            services.AddScoped<ILeaveRepository, LeaveRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository,EmployeeRepository>();
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<IExpenseClaimRepository, ExpenseClaimRepository>();
            services.AddScoped<IExpenseClaimDetailRepository, ExpenseClaimDetailRepository>();
        }
    }
}
