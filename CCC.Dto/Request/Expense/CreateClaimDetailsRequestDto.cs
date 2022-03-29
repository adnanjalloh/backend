using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Expense
{
    public class CreateClaimDetailsRequestDto
    {
        public int ExpenseClaimDetailId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public int ExpenseClaimId { get; set; }
    }
}
