using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Leave
{
    public class SearchLeaveRequestDto
    {
        public int EmployeeId { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
    }
}
