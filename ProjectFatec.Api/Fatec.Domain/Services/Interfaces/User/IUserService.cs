using System.Threading.Tasks;
using UserEntity = Fatec.Domain.Entities.User.User;

namespace Fatec.Domain.Services.Interfaces.User
{
    public interface IUserService
    {
        public Task<UserEntity> GetUserById(long userId);
    }
}
