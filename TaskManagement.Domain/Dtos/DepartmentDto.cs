using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Domain.Dtos
{
    public class DepartmentDto : BaseEntityDto
    {
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        public List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
    }
}
