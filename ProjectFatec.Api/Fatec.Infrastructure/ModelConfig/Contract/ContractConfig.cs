using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ContractEntity = Fatec.Domain.Entities.Contract.Contract;

namespace Fatec.Infrastructure.ModelConfig.Contract
{
    public class ContractConfig : IEntityTypeConfiguration<ContractEntity>
    {
        public void Configure(EntityTypeBuilder<ContractEntity> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
