using Fatec.Domain.Entities.Job;
using Fatec.Domain.Repositories.Interfaces;
using Fatec.Infrastructure.Context;
using System;

namespace Fatec.Infrastructure.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        private readonly BicoContext _context;
        public JobRepository(BicoContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
