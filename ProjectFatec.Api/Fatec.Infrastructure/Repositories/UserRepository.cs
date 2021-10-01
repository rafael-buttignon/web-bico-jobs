using Fatec.Domain.Entities.User;
using Fatec.Domain.Repositories.Interfaces;
using Fatec.Infrastructure.Context;
using System;

namespace Fatec.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly BicoContext _context;

        public UserRepository(BicoContext context): base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //public void GetUserById()
        //{

        //}
    }
}
