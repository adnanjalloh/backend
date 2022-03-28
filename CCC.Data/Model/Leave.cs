using System.ComponentModel.DataAnnotations;

namespace CCC.Data.Model
{
    public class Leave
    {
        public int LeaveId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double NumberOfDays => (To - From).TotalDays;
        [MaxLength(512)]
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }

    }
}
