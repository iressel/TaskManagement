using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Domain.Dtos
{
    public class TaskDto : BaseEntityDto
    {
        [Required(ErrorMessage = "Description is Required")]
        [MinLength(3)]
        [MaxLength(300)]
        public string? Description { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public EmployeeDto Employee { get; set; } = new EmployeeDto();
    }
}
