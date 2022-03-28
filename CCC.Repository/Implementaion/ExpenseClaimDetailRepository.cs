using CCC.Common.Util.Sql;
using CCC.Data;
using CCC.Data.Model;
using CCC.Repository.Interface;

namespace CCC.Repository.Implementaion
{
    public class ExpenseClaimDetailRepository : Repository<ExpenseClaimDetail, AppDbContext>, IExpenseClaimDetailRepository
    {
        public ExpenseClaimDetailRepository(SqlExecptionHandler sqlExecptionHandler, AppDbContext context) : base(sqlExecptionHandler, context)
        {
        }

        

    }
}
