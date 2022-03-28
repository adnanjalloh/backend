using System.ComponentModel.DataAnnotations;

namespace CCC.Data.Model
{
    public class LeaveType
    {
        public int LeaveTypeId { get; set; }
        [MaxLength(32)]
        public string Title { get; set; }
    }
}
