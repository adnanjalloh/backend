using CCC.Common.Action;

namespace CCC.Common.Util.Result
{
    public static class ResultUtils
    {
        public static void MapValues(this OperationResult target, OperationResult source)
        {
            target.Result = source.Result;
            target.Message = source.Message;
            target.Errors = source.Errors;
        }
        public static void MapValues<T, R>(this OperationResult<T> target, OperationResult<R> source)
        {
            target.Result = source.Result;
            target.Message = source.Message;
            target.Errors = source.Errors;
        }
        public static void MapValues<T, R>(this PaggingOperationResult<T> target, PaggingOperationResult<R> source)
        {
            target.Result = source.Result;
            target.Message = source.Message;
            target.Errors = source.Errors;
            target.Pagination = source.Pagination;
        }


        public static void PrepareExceptionResult(this OperationResult result, Exception ex, string errorMessage = "")
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = string.IsNullOrEmpty(errorMessage) ? "Error" : errorMessage
            });

        }
        public static void PrepareExceptionResult<T>(this OperationResult<T> result, Exception ex, string errorMessage = "")
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = string.IsNullOrEmpty(errorMessage) ? "Error" : errorMessage
            });
        }
        public static void PrepareExceptionResult<T>(this PaggingOperationResult<T> result, Exception ex, string errorMessage = "")
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = string.IsNullOrEmpty(errorMessage) ? "Error" : errorMessage
            });
        }


        public static void PrepareMissingParameterResult(this OperationResult result, string missingParameter)
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = $"Missing Parameter {missingParameter}"
            });
        }
        public static void PrepareMissingParameterResult<T>(this OperationResult<T> result, string missingParameter)
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = $"Missing Parameter {missingParameter}"
            });
        }
        public static void PrepareMissingParameterResult<T>(this PaggingOperationResult<T> result, string missingParameter)
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = $"Missing Parameter {missingParameter}"
            }) ;
        }


        public static void PrepareNotFoundResult(this OperationResult result, string errorMessage = "")
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = string.IsNullOrEmpty(errorMessage) ? "Not found." : errorMessage
            });
        }
        public static void PrepareNotFoundResult<T>(this OperationResult<T> result, string errorMessage = "")
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = string.IsNullOrEmpty(errorMessage) ? "Not found." : errorMessage
            });
        }
        public static void PrepareNotFoundResult<T>(this PaggingOperationResult<T> result, string errorMessage = "")
        {
            result.Errors.Add(new Error
            {
                ErrorMessage = string.IsNullOrEmpty(errorMessage) ? "Not found." : errorMessage
            });
        }

        public static void PrepareSuccessResult(this OperationResult result, string message = "")
        {
            result.Message = string.IsNullOrEmpty(message) ? "Operation has been occurred successfully" : message;
            result.Result = true;
        }
        public static void PrepareSuccessResult<T>(this OperationResult<T> result, string message = "")
        {
            result.Message = string.IsNullOrEmpty(message) ? "Operation has been occurred successfully" : message;
            result.Result = true;
        }
        public static void PrepareSuccessResult<T>(this PaggingOperationResult<T> result, string message = "")
        {
            result.Message = string.IsNullOrEmpty(message) ? "Operation has been occurred successfully" : message;
            result.Result = true;
        }
    }
}
