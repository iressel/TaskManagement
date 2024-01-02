using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;
using TaskManagement.Infrastructure.Context;
using TaskManagement.Infrastructure.Interfaces;

namespace TaskManagement.Infrastructure.Repositories
{
    public class EmployeesRepository : Repository<Employee>, IEmployeesRepository
    {
        private readonly TaskManagementDbContext _context;

        public EmployeesRepository(TaskManagementDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployeesByFilter(string sortOrder, string currentFilter, int pageNumber = 1)
        {
            IQueryable<Employee> query = _context.Employees
                .AsNoTracking()
                .Include(e => e.Tickets)
                .ThenInclude(t => t.Comments)
                .Include(e => e.Addresses)
                .Include(e => e.Department)
                .AsSplitQuery();

            if (!string.IsNullOrEmpty(currentFilter)) 
            {
                query.Where(x => x.IsDeleted == "0" &&
               (
                    x.Name.ToUpper().Contains(currentFilter) ||
                    x.Lastname.ToUpper().Contains(currentFilter) ||
                    x.Email.ToUpper().Contains(currentFilter)
               ));
            }

            if (!string.IsNullOrEmpty(sortOrder)) 
            {
                if (sortOrder == "Name_asc")
                {
                    query = query.OrderBy(x => x.Name);
                }
                else if (sortOrder == "Name_desc")
                {
                    query = query.OrderByDescending(x => x.Name);
                }
            }

           
            return await query.Skip((pageNumber - 1) * 10).Take(10).ToListAsync();
        }
    }
}
