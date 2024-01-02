using System;
using TaskManagement.Domain.Common;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Comment : BaseEntity
    {
        public string Description { get; set; }

        #region Navigation Properties
        public Guid TicketId { get; set; } // Required foreign key property
        public Ticket Ticket { get; set; } = null!; // Required reference navigation to principal
        #endregion
    }
}
