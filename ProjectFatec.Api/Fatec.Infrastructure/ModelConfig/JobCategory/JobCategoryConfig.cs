using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobCategoryEntity = Fatec.Domain.Entities.JobCategory.JobCategory;

namespace Fatec.Infrastructure.ModelConfig.JobCategory
{
    public class JobCategoryConfig : IEntityTypeConfiguration<JobCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<JobCategoryEntity> builder)
        {
            builder.Property(x => x.Description).IsRequired();

            builder.HasMany(x => x.Jobs)
                .WithOne(p => p.JobCategory);
        }
    }
}
