using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobEntity = Fatec.Domain.Entities.Job.Job;

namespace Fatec.Infrastructure.ModelConfig.Job
{
    public class JobConfig : IEntityTypeConfiguration<JobEntity>
    {
        public void Configure(EntityTypeBuilder<JobEntity> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
