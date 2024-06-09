using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        

        public Task<IEnumerable<User>> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUser(string email, string password)
        {
            return await UserDao.Instance.GetUser(email, password);
        }

        public async Task<User?> GetById(int id)
        {
            return await UserDao.Instance.GetUserById(id);
        }

        public async Task<int> Update(int id, User entity)
        {
           return await UserDao.Instance.UpdateUser(id, entity);
        }

        public async Task<IEnumerable<User?>?> Gets()
        {
            return await UserDao.Instance.GetUsers();
        }

        public async Task<int> Create(User entity)
        {
            return await UserDao.Instance.CreateUser(entity);
        }
    }
}
