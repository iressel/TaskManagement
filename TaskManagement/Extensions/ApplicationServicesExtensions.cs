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
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();

            //SERVICES
            services.AddScoped<IEmployeesService, EmployeesService>();


            services.AddLogging();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        }
    }
}
