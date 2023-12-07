using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Domain.Dtos
{
    public class AddressDto : BaseEntityDto
    {
        [Required(ErrorMessage = "Country is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Country { get; set; }

        [Required(ErrorMessage = "State is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? State { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? City { get; set; }

        [Required(ErrorMessage = "Street is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Street { get; set; }

        [Required(ErrorMessage = "AddressNumber is Required")]
        [MinLength(1)]
        [MaxLength(100)]
        public string? AddressNumber { get; set; }

        public string? IsOnTheGroundFloor { get; set; }

        public string? DepartmentNumber { get; set; }

        public string? DepartmentLetter { get; set; }

        [Required(ErrorMessage = "ZipCode is Required")]
        [MinLength(1)]
        [MaxLength(100)]
        public string? ZipCode { get; set; }

        public string? DetailedAddress { get; set; }
    }
}
