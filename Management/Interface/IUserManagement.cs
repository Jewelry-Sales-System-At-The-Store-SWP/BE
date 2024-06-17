using BusinessObjects.DTO;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace Management.Interface
{
    public interface IUserManagement
    {
        public Task<TokenResponseDto?> Login(LoginDto loginDto);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<IEnumerable<BillDetailDto?>?> GetBills();
        public Task<BillDetailDto?> GetBillById(string id);
        public Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto);
        
        public Task<User?> GetUserById(string id);
        public Task<int> AddUser(UserDto userDto);
        public Task<int> UpdateUser(string id, UserDto userDto);
        
        public Task<int> DeleteUser(string id);
    }
}
