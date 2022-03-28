namespace CCC.Dto.Response.Expense
{
    public class SearchExpenseClaimResponseDto
    {
        public int ExpenseClaimId { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeTitle { get; set; }
    }
}
