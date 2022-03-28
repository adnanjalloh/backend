namespace CCC.Dto.Response.Expense
{
    public class GetClaimDetailsResponseDto
    {
        public int ExpenseClaimDetailId { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int ExpenseClaimId { get; set; }
    }
}
