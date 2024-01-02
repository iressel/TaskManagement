using TaskManagement.Domain.Aggregates.DepartmentAggregate;
using TaskManagement.Domain.Dtos;

namespace TaskManagement.Infrastructure.Interfaces
{
    public interface IEmployeesRepository : IRepository<Employee>
    {
        Task<List<Employee>> GetEmployeesByFilter(string sortOrder, string currentFilter, int pageNumber = 1);
    }
}
