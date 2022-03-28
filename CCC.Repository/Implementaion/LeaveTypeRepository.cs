using CCC.Common.Util.Sql;
using CCC.Data;
using CCC.Data.Model;
using CCC.Repository.Interface;

namespace CCC.Repository.Implementaion
{
    public class LeaveTypeRepository : Repository<LeaveType, AppDbContext>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(SqlExecptionHandler sqlExecptionHandler, AppDbContext context) : base(sqlExecptionHandler, context)
        {
        }
    }
}
