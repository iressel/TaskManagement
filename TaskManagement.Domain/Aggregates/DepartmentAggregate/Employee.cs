using TaskManagement.Domain.Aggregates.PersonAggregate;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Employee : Person
    {
        public Employee()
        {
            Tickets = new List<Ticket>();
        }

        public string? Position { get; set; }

        public string? Status { get; set; }

        #region Navigation Properties
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
        #endregion

        #region Inverse Navigation Properties

        public virtual ICollection<Ticket> Tickets { get; set; }

        #endregion
    }
}
