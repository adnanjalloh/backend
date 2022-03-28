namespace CCC.Common.Action
{
    public class OperationResult
    {
        public OperationResult()
        {
            Errors = new List<Error>();
        }
        public bool Result { get; set; }
        public string Message { get; set; }
        public List<Error> Errors { get; set; }
        
    }

    public class OperationResult<TResponse> : OperationResult
    {
        public OperationResult() { }
        public OperationResult(TResponse response)
        {
            Response = response;
        }

        public OperationResult(OperationResult result)
        {
            Result = result.Result;
            Message = result.Message;
            Errors = result.Errors;
            
        }
        public TResponse Response { get; set; }
    }

    public class PaggingOperationResult<TResponse> : OperationResult<List<TResponse>>
    {
        public PaggingOperationResult()
        {
            Response = new List<TResponse>();
            Pagination = new Pagination();
        }
        public PaggingOperationResult(List<TResponse> responses)
        {
            Response = responses;
        }
        public PaggingOperationResult(OperationResult result)
        {
            Result = result.Result;
            Message = result.Message;
            Errors = result.Errors;
            Response = new List<TResponse>();
        }
        public Pagination Pagination { get; set; }
    }
    public class Pagination
    {
        public int TotalResults { get; set; }
        public int CurrentPage { get; set; }
        public int ResultsPerPage { get; set; }
        public int Pages { get; set; }
        public int LastPage { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }

    public class Error
    {
        public string ErrorMessage { get; set; }
    }
}
