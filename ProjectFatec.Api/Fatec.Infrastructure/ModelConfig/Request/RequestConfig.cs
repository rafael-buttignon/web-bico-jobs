using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequestEntity = Fatec.Domain.Entities.Request.Request;

namespace Fatec.Infrastructure.ModelConfig.Request
{
    public class RequestConfig : IEntityTypeConfiguration<RequestEntity>
    {
        public void Configure(EntityTypeBuilder<RequestEntity> builder)
        {

        }
    }
}
