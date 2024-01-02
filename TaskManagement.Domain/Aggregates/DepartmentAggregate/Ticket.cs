using TaskManagement.Domain.Common;
using TaskManagement.Domain.Shared.Enums;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Ticket : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public DateTime? DeliveryDate { get; set; }
        public TicketStatus Status { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Subtask> Subtasks { get; set; }

        #region Navigation Properties
        public Guid EmployeeId { get; set; } // Required foreign key property
        public Employee Employee { get; set; } = null!; // Required reference navigation to principal
        #endregion
    }
}
