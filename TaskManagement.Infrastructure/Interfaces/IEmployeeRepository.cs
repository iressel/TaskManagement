using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;

namespace TaskManagement.Infrastructure.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
