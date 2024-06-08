﻿using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class UserDao : Singleton<UserDao>
    {
        private readonly JssatsContext _context;

        public UserDao()
        {
            _context = new JssatsContext();
        }

        public async Task<User?> GetUser(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
        }
        public async Task<IEnumerable<User?>?> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
