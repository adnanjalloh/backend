using CCC.Common.Action;
using CCC.Common.Util.Result;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CCC.Common.Util.Sql
{
    public class SqlExecptionHandler
    {
        private readonly ILogger<SqlExecptionHandler> _logger;

        private const int SqlServerViolationOfUniqueIndex = 2601;
        private const int SqlServerViolationOfUniqueConstraint = 2627;
        public SqlExecptionHandler(ILogger<SqlExecptionHandler> logger)
        {
            _logger = logger;
        }

        public void HandelException
            (Exception e, OperationResult result)
        {
            result.PrepareExceptionResult(e);
            
            _logger.LogError(e, "SqlExecption");
            if (e.InnerException != null && e.InnerException is SqlException)
            {
                var sqlEx = e.InnerException as SqlException;

                //This is a DbUpdateException on a SQL database

                if (sqlEx.Number == SqlServerViolationOfUniqueIndex ||
                    sqlEx.Number == SqlServerViolationOfUniqueConstraint)
                {
                    //We have an error we can process
                    UniqueErrorFormatter(sqlEx, result);
                }
            }
        }

        private readonly Regex UniqueConstraintRegex = 
            new("'UniqueError_([a-zA-Z0-9]*)_([a-zA-Z0-9]*)'", RegexOptions.Compiled);

        private void UniqueErrorFormatter(SqlException ex, OperationResult result)
        {
            var message = ex.Errors[0].Message;
            var matches = UniqueConstraintRegex.Matches(message);

            if (matches.Count == 0)
                return;

            var entityDisplayName = matches[0].Groups[1].Value;

            _logger.LogError("Cannot have a duplicate {value} in  {entity}", matches[0].Groups[2].Value, entityDisplayName);

            var openingBadValue = message.IndexOf("(");
            if (openingBadValue > 0)
            {
                var dupPart = message.Substring(openingBadValue + 1,
                    message.Length - openingBadValue - 3);

                _logger.LogError("Duplicate value was  {value}", dupPart);
            }

            result.Errors.Add(new Error
            {
                ErrorMessage = $"Used Before {matches[0].Groups[2].Value}" 
            });
        }
    }
}
