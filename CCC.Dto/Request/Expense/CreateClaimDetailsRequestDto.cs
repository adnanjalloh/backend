using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Expense
{
    public class CreateClaimDetailsRequestDto
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int ExpenseClaimId { get; set; }
    }
}
