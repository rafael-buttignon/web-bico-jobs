using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ContractStatusEntity = Fatec.Domain.Entities.ContractStatus.ContractStatus;

namespace Fatec.Infrastructure.ModelConfig.ContractStatus
{
    public class ContractStatusConfig : IEntityTypeConfiguration<ContractStatusEntity>
    {
        public void Configure(EntityTypeBuilder<ContractStatusEntity> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
