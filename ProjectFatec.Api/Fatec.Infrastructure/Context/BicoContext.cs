using Fatec.Domain.Entities;
using Fatec.Domain.Services.Interfaces.Clock;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Fatec.Infrastructure.Context
{
    public class BicoContext : DbContext
    {
        private readonly IClock _clock;

        public BicoContext(DbContextOptions options,
            IClock clock) : base(options)
        {
            _clock = clock;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var addedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified).ToList();
            addedEntities.ForEach(entityEntry =>
            {
                if (!(entityEntry.Entity is Entity entity))
                    return;

                if (entityEntry.State == EntityState.Added)
                {
                    entity.CreatedOn = _clock.UtcDateTimeNow();
                }

                if (entityEntry.State != EntityState.Modified) return;

                entity.UpdatedOn = _clock.UtcDateTimeNow();
            });

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
