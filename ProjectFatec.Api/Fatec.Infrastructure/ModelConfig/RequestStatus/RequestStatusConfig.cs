using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestStatusEntity = Fatec.Domain.Entities.RequestStatus.RequestStatus;

namespace Fatec.Infrastructure.ModelConfig.RequestStatus
{
    public class RequestStatusConfig : IEntityTypeConfiguration<RequestStatusEntity>
    {
        public void Configure(EntityTypeBuilder<RequestStatusEntity> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
