using System.ComponentModel.DataAnnotations;

namespace CCC.Dto.Request.Leave
{
    public class CreateLeaveTypeRequestDto
    {
        [Required]
        public string Title { get; set; }
    }
}
