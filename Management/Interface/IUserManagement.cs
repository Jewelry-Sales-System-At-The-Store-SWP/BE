using BusinessObjects.Dto;
using BusinessObjects.Dto.Bill;
using BusinessObjects.Models;

namespace Management.Interface
{
    public interface IUserManagement
    {
        public Task<User?> Login(LoginDto loginDto);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<IEnumerable<Bill?>?> GetBills();
        public Task<Bill?> GetBillById(int id);
        public Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto);
        
        public Task<User> GetUserById(int id);
        public Task<int> AddUser(UserDto? userDto);
        public Task<int> UpdateUser(int id, UserDto userDto);
        
        public Task<int> DeleteUser(int id);
    }
}
