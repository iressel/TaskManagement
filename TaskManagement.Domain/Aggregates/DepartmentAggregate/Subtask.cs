using TaskManagement.Domain.Common;
using TaskManagement.Domain.Shared.Enums;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Subtask : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public DateTime? DeliveryDate { get; set; }
        public TicketStatus Status { get; set; }

        #region Navigation Properties
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; } = null!;
        #endregion
    }
}
