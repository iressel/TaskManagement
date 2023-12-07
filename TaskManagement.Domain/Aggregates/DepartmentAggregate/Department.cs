using TaskManagement.Domain.Common;

namespace TaskManagement.Domain.Aggregates.DepartmentAggregate
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Employees = new List<Employee>();
        }

        public string? Name { get; set; }

        #region Inverse Navigation Properties

        public virtual ICollection<Employee> Employees { get; set; }

        #endregion
    }
}
