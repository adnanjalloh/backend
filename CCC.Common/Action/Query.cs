namespace CCC.Common.Action
{
    public class Query
    {
        public Query()
        {
            PerPage = 10;
        }
        public int Page { get; set; }
        public int PerPage { get; set; }
        public string OrderBy { get; set; }
        public string OrderDir { get; set; }
    }
    public class Query<T> : Query
    {
        public Query()
        {

        }
        public Query(T param)
        {
            Parameter = param;
        }
        public T Parameter { get; set; }
    }
}
