using TaskManagement.Domain.Common;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Task : BaseEntity
    {
        public string? Description { get; set; }

        public DateTime? DeliveryDate { get; set; }

        #region Navigation Properties
        public Guid EmployeeId { get; set; } // Required foreign key property
        public Employee Employee { get; set; } = null!; // Required reference navigation to principal
        #endregion
    }
}
