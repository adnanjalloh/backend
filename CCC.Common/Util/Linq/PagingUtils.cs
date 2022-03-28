using CCC.Common.Action;
using System.Linq.Expressions;
using System.Reflection;

namespace CCC.Common.Util.Linq
{
    public static class PagingUtils
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> objects, int pageSize, int page)
        {

            if (pageSize < 1)
                pageSize = 10;

            if (page < 0)
                page = 0;

            return objects?.Skip(page * pageSize).Take(pageSize);
        }

        public static int PagesCount(int all, int pageSize)
        {
            if (pageSize < 1)
                pageSize = 10;

            return pageSize < 0 ? 0 : ((all / pageSize) + (all % pageSize > 0 ? 1 : 0));
        }


        public static IQueryable<T> OrderBy<T>(this IQueryable<T> objects, Query query)
        {
            if (string.IsNullOrWhiteSpace(query.OrderBy))
                query.OrderBy = typeof(T).Name + "Id";

            if (!query.OrderBy.Contains('.'))
            {
                var props = typeof(T).GetProperties();
                if (!props.Any(p => p.Name.ToLower().Equals(query.OrderBy, System.StringComparison.OrdinalIgnoreCase)))
                {
                    if (props.Any(p => p.Name.ToLower().Equals("CreationTime".ToLower())))
                    {
                        query.OrderBy = "CreationTime";
                    }
                    else if (props.Any(p => p.Name.ToLower().Equals("Id".ToLower())))
                    {
                        query.OrderBy = typeof(T).Name + "Id";
                    }
                }
            }

            if (string.IsNullOrEmpty(query.OrderDir))
                query.OrderDir = "asc";


            return query.OrderDir switch
            {
                "asc" => objects?.OrderBy($"{query.OrderBy}"),
                "desc" => objects?.OrderByDesc($"{query.OrderBy}"),
                _ => objects?.OrderBy($"{query.OrderBy}"),
            };
        }

        public static IOrderedQueryable<TSource> OrderBy<TSource>(
       this IQueryable<TSource> query, string propertyName)
        {
            var entityType = typeof(TSource);

            //Create x=>x.PropName
            var propertyInfo = entityType.GetProperty(propertyName);
            ParameterExpression arg = Expression.Parameter(entityType, "x");
            MemberExpression property = Expression.Property(arg, propertyName);
            var selector = Expression.Lambda(property, new ParameterExpression[] { arg });

            //Get System.Linq.Queryable.OrderBy() method.
            var enumarableType = typeof(System.Linq.Queryable);
            var method = enumarableType.GetMethods()
                 .Where(m => m.Name == "OrderBy" && m.IsGenericMethodDefinition)
                 .Where(m =>
                 {
                     var parameters = m.GetParameters().ToList();
                     //Put more restriction here to ensure selecting the right overload                
                     return parameters.Count == 2;//overload that has 2 parameters
                 }).Single();
            //The linq's OrderBy<TSource, TKey> has two generic types, which provided here
            MethodInfo genericMethod = method
                 .MakeGenericMethod(entityType, propertyInfo.PropertyType);

            /*Call query.OrderBy(selector), with query and selector: x=> x.PropName
              Note that we pass the selector as Expression to the method and we don't compile it.
              By doing so EF can extract "order by" columns and generate SQL for it.*/
            var newQuery = (IOrderedQueryable<TSource>)genericMethod
                 .Invoke(genericMethod, new object[] { query, selector });
            return newQuery;
        }
        public static IOrderedQueryable<TSource> OrderByDesc<TSource>(
      this IQueryable<TSource> query, string propertyName)
        {
            var entityType = typeof(TSource);

            //Create x=>x.PropName
            var propertyInfo = entityType.GetProperty(propertyName);
            ParameterExpression arg = Expression.Parameter(entityType, "x");
            MemberExpression property = Expression.Property(arg, propertyName);
            var selector = Expression.Lambda(property, new ParameterExpression[] { arg });

            //Get System.Linq.Queryable.OrderBy() method.
            var enumarableType = typeof(Queryable);
            var method = enumarableType.GetMethods()
                 .Where(m => m.Name == "OrderByDescending" && m.IsGenericMethodDefinition)
                 .Where(m =>
                 {
                     var parameters = m.GetParameters().ToList();
                     //Put more restriction here to ensure selecting the right overload                
                     return parameters.Count == 2;//overload that has 2 parameters
                 }).Single();
            //The linq's OrderBy<TSource, TKey> has two generic types, which provided here
            MethodInfo genericMethod = method
                 .MakeGenericMethod(entityType, propertyInfo.PropertyType);

            /*Call query.OrderBy(selector), with query and selector: x=> x.PropName
              Note that we pass the selector as Expression to the method and we don't compile it.
              By doing so EF can extract "order by" columns and generate SQL for it.*/
            var newQuery = (IOrderedQueryable<TSource>)genericMethod
                 .Invoke(genericMethod, new object[] { query, selector });
            return newQuery;
        }

    }
}
