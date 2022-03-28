using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Expense
{
    public class CreateClaimRequestDto
    {
        [Required]
        public string Description { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        public int ExpenseClaimId { get; set; }
    }
}
