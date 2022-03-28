using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Expense
{
    public class SearchExpenseClaimRequestDto
    {
        [Required]
        public int EmployeeId { get; set; }
    }
}
