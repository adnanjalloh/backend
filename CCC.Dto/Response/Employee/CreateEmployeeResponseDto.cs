namespace CCC.Dto.Response.Employee
{
    public class CreateEmployeeResponseDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
    }
}
