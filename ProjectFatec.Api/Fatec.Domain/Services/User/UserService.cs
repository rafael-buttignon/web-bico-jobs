using Fatec.Domain.Repositories.Interfaces;
using Fatec.Domain.Services.Interfaces.User;
using System;
using System.Threading.Tasks;
using UserEntity = Fatec.Domain.Entities.User.User;

namespace Fatec.Domain.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
        { 
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public async Task<UserEntity> GetUserById(long userId)
        {
            return await _userRepository.FindById(userId);
        }
    }
}
