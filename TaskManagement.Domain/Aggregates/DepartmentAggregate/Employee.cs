using TaskManagement.Domain.Aggregates.PersonAggregate;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Employee : Person
    {
        public Employee()
        {
            Tasks = new List<Task>();
        }

        public string? Position { get; set; }

        public string? Status { get; set; }

        #region Navigation Properties
        public Guid DepartmentId { get; set; } // Required foreign key property
        public Department Department { get; set; } = null!; // Required reference navigation to principal
        #endregion

        #region Inverse Navigation Properties

        public virtual ICollection<Task> Tasks { get; set; }

        #endregion
    }
}
