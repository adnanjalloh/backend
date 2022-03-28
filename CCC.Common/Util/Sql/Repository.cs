using CCC.Common.Action;
using CCC.Common.Util.Result;
using CCC.Common.Util.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CCC.Common.Util.Sql
{
    public class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {

        private readonly SqlExecptionHandler _sqlExecptionHandler;
        private readonly TContext _context;
        public Repository(SqlExecptionHandler sqlExecptionHandler, TContext context)
        {
            _sqlExecptionHandler = sqlExecptionHandler;
            _context = context;
        }

        public async Task<OperationResult<TEntity>> AddAsync(TEntity entity)
        {
            OperationResult<TEntity> result = new();
            try
            {

                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                await _context.SaveChangesAsync();
                await _context.Entry(entity).ReloadAsync();
                result.Response = entity;
                result.Result = true;

            }
            catch (Exception ex)
            {
                _sqlExecptionHandler.HandelException(ex, result);
            }
            return result;
        }

        public async Task<OperationResult<TEntity>> DeleteAsync(TEntity entity)
        {
            OperationResult<TEntity> result = new();
            try
            {

                var deletedEntity = _context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                result.Response = entity;
                result.Result = true;
            }
            catch (Exception ex)
            {
                _sqlExecptionHandler.HandelException(ex, result);
            }
            return result;
        }

        public async Task<OperationResult<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter, string includeExpression = null)
        {
            OperationResult<TEntity> result = new();
            try
            {
                IQueryable<TEntity> query = _context.Set<TEntity>().Where(filter);

                query = HandleInclude(includeExpression, query);

                result.Response = await query.AsNoTracking().FirstOrDefaultAsync();
                if (result.Response == null)
                {
                    result.PrepareNotFoundResult();
                    return result;
                }

                result.Result = true;
            }
            catch (Exception ex)
            {
                _sqlExecptionHandler.HandelException(ex, result);
            }
            return result;
        }

        public async Task<PaggingOperationResult<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null,
            Query query = null,
            string includeExpression = null)
        {
            PaggingOperationResult<TEntity> result = new();
            try
            {
                if (query == null)
                    query = new Query();

                IQueryable<TEntity> queryable;
                if (filter == null)
                {
                    queryable = _context.Set<TEntity>().Select(a => a);
                }
                else
                {
                    queryable = _context.Set<TEntity>().Where(filter);
                }

                queryable = HandleInclude(includeExpression, queryable);


                result.Pagination = new Pagination
                {
                    ResultsPerPage = query.PerPage,
                    CurrentPage = query.Page,
                    TotalResults = await queryable.CountAsync(),
                };

                result.Response = await queryable
                    .Page(query.PerPage, query.Page)
                    .AsNoTracking()
                    .ToListAsync();

                result.Result = true;
            }
            catch (Exception ex)
            {
                _sqlExecptionHandler.HandelException(ex, result);
            }
            return result;
        }

        public async Task<OperationResult<TEntity>> UpdateAsync(TEntity entity)
        {
            OperationResult<TEntity> result = new();
            try
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await _context.SaveChangesAsync();
                await _context.Entry(entity).ReloadAsync();
                result.Response = entity;
                result.Result = true;
            }
            catch (Exception ex)
            {
                _sqlExecptionHandler.HandelException(ex, result);
            }
            return result;

        }

        private static IQueryable<TEntity> HandleInclude(string includeExpression, IQueryable<TEntity> queryable)
        {
            if (!string.IsNullOrEmpty(includeExpression))
            {
                var includes = includeExpression.Split(';');
                foreach (string include in includes)
                {
                    var sinclude = include.Trim();

                    if (!string.IsNullOrEmpty(sinclude))
                        queryable = queryable.Include(sinclude);
                }
            }
            return queryable;
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, string includeExpression = null)
        {
            IQueryable<TEntity> queryable = null;
            if (filter == null)
            {
                queryable = _context.Set<TEntity>().Select(a => a);
            }
            else
            {
                queryable = _context.Set<TEntity>().Where(filter);
            }
            return HandleInclude(includeExpression, queryable);
        }

        public async Task<OperationResult<List<TEntity>>> AddRangeAsync(List<TEntity> entities)
        {
            OperationResult<List<TEntity>> result = new();
            try
            {

                var addedEntities = _context.AddRangeAsync(entities);
                await _context.SaveChangesAsync();
                await _context.Entry(entities).ReloadAsync();
                result.Response = entities;
                result.Result = true;

            }
            catch (Exception ex)
            {
                _sqlExecptionHandler.HandelException(ex, result);
            }
            return result;
        }
    }
}
