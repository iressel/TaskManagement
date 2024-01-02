using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Aggregates.PersonAggregate;

namespace TaskManagement.Domain.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entityBuilder) 
        {
            //entityBuilder.Property(c => c.Street).HasColumnType("varchar(150)");
        }
    }
}
