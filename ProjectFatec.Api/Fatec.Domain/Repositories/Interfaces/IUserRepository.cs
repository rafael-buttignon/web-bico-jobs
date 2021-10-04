using Fatec.Domain.Entities.User;
using System.Threading.Tasks;

namespace Fatec.Domain.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        //public void GetUserById();
        public Task<User> GetUserByEmail(string email);
    }
}
