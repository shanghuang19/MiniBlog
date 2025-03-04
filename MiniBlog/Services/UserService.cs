﻿using MiniBlog.Model;
using MiniBlog.Repositories;
using System.Threading.Tasks;

namespace MiniBlog.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository = null!;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> CreateUser(User user)
        {
            var createdUser = await userRepository.CreateUser(user);
            return createdUser;
        }

        public async Task<bool> IsUserExist(string userName)
        {
            var foundUser = await userRepository.GetOneUser(userName);
            return foundUser != null;
        }
    }
}
