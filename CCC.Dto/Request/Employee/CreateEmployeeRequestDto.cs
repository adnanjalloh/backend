using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Employee
{
    public class CreateEmployeeRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}
