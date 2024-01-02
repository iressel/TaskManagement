using TaskManagement.Domain.Aggregates.DepartmentAggregate;
using TaskManagement.Domain.Common;

namespace TaskManagement.Domain.Aggregates.PersonAggregate
{
    public class Address : BaseEntity
    {
        public string? Country { get; set; }

        public string? State { get; set; }

        public string? City { get; set; }

        public string? Street { get; set; }

        public string? AddressNumber { get; set; }

        public bool? IsOnTheGroundFloor { get; set; }

        public string? DepartmentNumber { get; set; }

        public string? DepartmentLetter { get; set; }

        public string? ZipCode { get; set; }

        public string? DetailedAddress { get; set; }

        #region Inverse Navigation Properties
        public Guid EmployeeId { get; set; } // Required foreign key property
        public Employee Employee { get; set; } = null!; // Required reference navigation to principal
        #endregion
    }
}
