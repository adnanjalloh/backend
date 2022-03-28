using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Expense
{
    public class GetClaimDetailsRequestDto
    {
        [Required]
        public int ClaimId { get; set; }
    }
}
