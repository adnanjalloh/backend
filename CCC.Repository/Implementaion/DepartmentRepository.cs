using CCC.Common.Util.Sql;
using CCC.Data;
using CCC.Data.Model;
using CCC.Repository.Interface;

namespace CCC.Repository.Implementaion
{
    public class DepartmentRepository : Repository<Department, AppDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(SqlExecptionHandler sqlExecptionHandler, AppDbContext context) : base(sqlExecptionHandler, context)
        {
        }
    }
}
