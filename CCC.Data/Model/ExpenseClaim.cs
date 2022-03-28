namespace CCC.Data.Model
{
    public class ExpenseClaim
    {
        public int ExpenseClaimId { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<ExpenseClaimDetail> ExpenseClaimDetails { get; set; }
    }

    public enum ExpenseClaimStatus
    {
        NotClaimed = 1,
        Claimed = 2,
    }
}
