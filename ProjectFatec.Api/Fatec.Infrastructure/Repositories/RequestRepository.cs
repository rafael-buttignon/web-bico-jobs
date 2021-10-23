using Fatec.Domain.Entities.Request;
using Fatec.Domain.Repositories.Interfaces;
using Fatec.Infrastructure.Context;
using System;

namespace Fatec.Infrastructure.Repositories
{
    public class RequestRepository : Repository<Request>, IRequestRepository
    {
        private readonly BicoContext _context;

        public RequestRepository(BicoContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
    }
}
