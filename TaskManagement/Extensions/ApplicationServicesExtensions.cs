using TaskManagement.Domain.Mappings;
using TaskManagement.Infrastructure.Interfaces;
using TaskManagement.Infrastructure.Repositories;
using TaskManagement.Services.Interfaces;
using TaskManagement.Services.Services;

namespace TaskManagement.Api.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services) 
        {
            //REPOSITORIES
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //SERVICES
            services.AddScoped<IEmployeeService, EmployeeService>();


            services.AddLogging();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        }
    }
}
