using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobEntity = Fatec.Domain.Entities.Job.Job;

namespace Fatec.Infrastructure.ModelConfig.Job
{
    public class JobConfig : IEntityTypeConfiguration<JobEntity>
    {
        public void Configure(EntityTypeBuilder<JobEntity> builder)
        {
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.StartTime)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.BreakTime)
                .HasColumnType("datetime");

            builder.Property(x => x.ReturnTime)
                .HasColumnType("datetime");

            builder.Property(x => x.EndTime)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.PriceTime)
                .IsRequired();

            builder.HasOne(x => x.JobCategory)
                .WithMany(x => x.Jobs)
                .HasForeignKey(x => x.JobCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany(x => x.Requests)
                .WithOne(x => x.Job)
                .HasForeignKey(x => x.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany(x => x.Contracts)
                .WithOne(x => x.Job)
                .HasForeignKey(x => x.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
