namespace CCC.Dto.Response.Leave
{
    public class CreateLeaveResponseDto
    {
        public int LeaveId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double NumberOfDays { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
