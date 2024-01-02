using AutoMapper;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;
using TaskManagement.Domain.Dtos;

namespace TaskManagement.Domain.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Addresses, m => m.MapFrom(source => source.Addresses))
                .ForMember(dest => dest.Department, m => m.MapFrom(source => source.Department))
                .ForMember(dest => dest.Tasks, m => m.MapFrom(source => source.Tickets));//.ReverseMap();
        }
    }
}
