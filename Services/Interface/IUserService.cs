﻿using BusinessObjects.Dto;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IUserService
    {
        public Task<User?> Login(LoginDto loginDto);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<bool> IsUser(string email, string password);
        public Task<int> AddUser(UserDto userDto);
        public Task<int> UpdateUser(int id, UserDto userDto);
        public Task<User?> GetUserById(int id);
        
        public Task<int> DeleteUser(int id);
    }
}
