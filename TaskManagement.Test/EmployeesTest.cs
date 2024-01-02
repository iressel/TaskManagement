using Microsoft.EntityFrameworkCore;
using TaskManagement.Infrastructure.Context;
using TaskManagement.Infrastructure.Interfaces;
using TaskManagement.Infrastructure.Repositories;

namespace TaskManagement.Test
{
    public class EmployeesTest : IClassFixture<DatabaseFixture>
    {
        private readonly IEmployeesRepository _employeeRepository;

        public EmployeesTest(DatabaseFixture fixture)
        {
            _employeeRepository = new EmployeesRepository(fixture.Context);
        }

        [Fact]
        public async Task GetEmployeesByFilter_ShouldReturnFilteredAndSortedEmployeesAsync()
        {
            // Act
            var result = await _employeeRepository.GetEmployeesByFilter("Name_asc", "claudio", 1);

            // Assert
            Assert.NotNull(result);
            // Agrega más aserciones según sea necesario
        }
    }

    public class DatabaseFixture : IDisposable
    {
        public TaskManagementDbContext Context { get; private set; }

        public DatabaseFixture()
        {
            var connectionString = "Server=DESKTOP-42KK2JH;Database=TaskManagementDB;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

            var options = new DbContextOptionsBuilder<TaskManagementDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            Context = new TaskManagementDbContext(options);

            // Configura el contexto según sea necesario (por ejemplo, agregar datos de prueba)
        }

        public void Dispose()
        {
            // Limpiar recursos si es necesario
            Context.Dispose();
        }
    }
}