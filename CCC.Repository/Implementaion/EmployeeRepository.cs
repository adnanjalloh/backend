using CCC.Common.Util.Sql;
using CCC.Data;
using CCC.Data.Model;
using CCC.Repository.Interface;

namespace CCC.Repository.Implementaion
{
    public class EmployeeRepository : Repository<Employee, AppDbContext>, IEmployeeRepository
    {
        public EmployeeRepository(SqlExecptionHandler sqlExecptionHandler, AppDbContext context) : base(sqlExecptionHandler, context)
        {
        }
    }
}
