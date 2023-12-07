using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;
using TaskManagement.Infrastructure.Context;
using TaskManagement.Infrastructure.Interfaces;

namespace TaskManagement.Infrastructure.Repositories
{
    public class EmployeesRepository : Repository<Employee>, IEmployeesRepository
    {
        public EmployeesRepository(TaskManagementDbContext context) : base(context)
        {

        }
    }
}
