using BusinessObjects.Context;
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
        public async Task<int> AddUser(User user)
        {
            _context.Users.Add(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateUser(int Id, User user)
        {
           var existUser = await _context.Users.FirstOrDefaultAsync(x => x.UserId == Id);
           if (existUser == null) return 0;
           existUser.Email = user.Email;
           existUser.Password = user.Password;
           existUser.CounterId = user.CounterId;
           existUser.RoleId = user.RoleId;
           existUser.Status = user.Status;
           return await _context.SaveChangesAsync();
        }
        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
