using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Dtos;
using TaskManagement.Infrastructure.Interfaces;
using TaskManagement.Services.Interfaces;

namespace TaskManagement.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            var result = await _employeeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EmployeeDto>>(result);
        }

        public Task<EmployeeDto?> GetEmployeeByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateEmployeeAsync(EmployeeDto product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployeeAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployeeAsync(EmployeeDto product)
        {
            throw new NotImplementedException();
        }
    }
}
