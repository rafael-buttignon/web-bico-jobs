using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AddressEntity = Fatec.Domain.Entities.Address.Address;

namespace Fatec.Infrastructure.ModelConfig.Address
{
    public class AddressConfig : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.Property(x => x.CEP).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Neighborhood).IsRequired();
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.Street).IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.Address);
        }
    }
}
