using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Leave
{
    public class CreateLeaveRequestDto
    {
        public int LeaveId { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        public string Note { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int LeaveTypeId { get; set; }
    }
}
