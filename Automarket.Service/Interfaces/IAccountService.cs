using System.Security.Claims;
using System.Threading.Tasks;
using AutoMarket.Domain.Response;
using AutoMarket.Domain.ViewModels.Account;

namespace AutoMarket.Service.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model);
    }
}