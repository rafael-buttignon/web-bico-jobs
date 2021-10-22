using Fatec.Domain.Entities.User;
using Fatec.Domain.Repositories.Interfaces;
using Fatec.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fatec.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly BicoContext _context;

        public UserRepository(BicoContext context): base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<User> GetUserByEmail(string email) 
        {
            return await DbSet.Where(x => x.Email == email).FirstOrDefaultAsync();
        }
    }
}
