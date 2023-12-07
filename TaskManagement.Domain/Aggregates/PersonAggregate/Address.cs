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

        public string? IsOnTheGroundFloor { get; set; }

        public string? DepartmentNumber { get; set; }

        public string? DepartmentLetter { get; set; }

        public string? ZipCode { get; set; }

        public string? DetailedAddress { get; set; }
    }
}
