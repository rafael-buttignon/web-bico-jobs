﻿using Fatec.Domain.Exceptions;
using Fatec.Domain.Repositories.Interfaces;
using Fatec.Domain.Repositories.Transaction;
using Fatec.Domain.Services.Interfaces.User;
using System;
using System.Threading.Tasks;
using UserEntity = Fatec.Domain.Entities.User.User;

namespace Fatec.Domain.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        { 
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<UserEntity> GetUserById(long userId)
        {
            return await _userRepository.FindById(userId);
        }

        public async Task<bool> CreateUser(UserEntity user) 
        {
            var userVerified = await _userRepository.GetUserByEmail(user.Email);

            if (userVerified != null) throw new UserAlreadyExistsException();

            _userRepository.Add(user);

            return await _unitOfWork.SaveChangesAsync();
        }
    }
}