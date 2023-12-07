using TaskManagement.Domain.Dtos;

namespace TaskManagement.Services.Interfaces
{
    public interface IEmployeesService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto?> GetEmployeeByIdAsync(Guid id);
        Task<bool> CreateEmployeeAsync(EmployeeDto product);
        Task<bool> UpdateEmployeeAsync(EmployeeDto product);
        Task<bool> DeleteEmployeeAsync(Guid id);
    }
}
