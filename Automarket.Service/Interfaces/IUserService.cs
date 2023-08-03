using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMarket.Domain.Models;
using AutoMarket.Domain.Response;
using AutoMarket.Domain.ViewModels.User;

namespace AutoMarket.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Create(UserViewModel model);
        
        BaseResponse<Dictionary<int, string>> GetRoles();
        
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();
        
        Task<IBaseResponse<bool>> DeleteUser(long id);
    }
}