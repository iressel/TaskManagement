using System.ComponentModel.DataAnnotations;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;

namespace TaskManagement.Domain.Dtos
{
    public class EmployeeDto : PersonDto
    {
        public string? Position { get; set; }

        [Required(ErrorMessage = "Status is Required")]
        [MaxLength(1)]
        public string? Status { get; set; }

        [Required(ErrorMessage = "Department is Required")]
        public DepartmentDto Department { get; set; } = new DepartmentDto();

        public List<TaskDto> Tasks { get; set; } = new List<TaskDto>();
    }
}
