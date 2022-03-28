namespace CCC.Dto.Response.Expense
{
    public class CreateClaimResponseDto
    {
        public int ExpenseClaimId { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int EmployeeId { get; set; }
    }
}
