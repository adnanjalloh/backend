using CCC.Common.Action;
using System.Linq.Expressions;

namespace CCC.Common.Util.Sql
{
    public interface IRepository<TEntity> where TEntity : class, new()
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="includeExpression">"Country;User;User.Country"</param>
		/// <returns></returns>
		Task<PaggingOperationResult<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null,
			Query query = null,
			string includeExpression = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="includeExpression">"Country;User;User.Country"</param>
		/// <returns></returns>
		Task<OperationResult<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter, string includeExpression = null);
		Task<OperationResult<TEntity>> AddAsync(TEntity entity);
		Task<OperationResult<TEntity>> UpdateAsync(TEntity entity);
		Task<OperationResult<TEntity>> DeleteAsync(TEntity entity);
		Task<OperationResult<List<TEntity>>> AddRangeAsync(List<TEntity> entities);
		
		IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, string includeExpression = null);
	}
}
