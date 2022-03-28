using CCC.Common.Util.Sql;
using CCC.Data;
using CCC.Data.Model;
using CCC.Repository.Interface;

namespace CCC.Repository.Implementaion
{
    public class ExpenseClaimRepository : Repository<ExpenseClaim, AppDbContext>, IExpenseClaimRepository
    {
        public ExpenseClaimRepository(SqlExecptionHandler sqlExecptionHandler, AppDbContext context) : base(sqlExecptionHandler, context)
        {
        }
    }
}
