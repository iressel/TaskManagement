using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskManagement.Domain.Dtos
{
    public class PersonDto : BaseEntityDto
    {
        public PersonDto()
        {
            Addresses = new List<AddressDto>();
        }

        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Surname is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Surname is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("File")]
        public string? Legajo { get; set; }

        [Required(ErrorMessage = "DocumentNumber is Required")]
        [MinLength(8)]
        [MaxLength(8)]
        public string? DocumentNumber { get; set; }

        [MinLength(11)]
        [MaxLength(11)]
        public string? CuitCuil { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? NationalityId { get; set; }

        public string? Phone { get; set; }

        public string? CellPhone { get; set; }

        public string? Email { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public List<AddressDto>? Addresses { get; set; }
    }
}
