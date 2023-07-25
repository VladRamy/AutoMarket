using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMarket.Domain.Models;
using AutoMarket.Domain.Response;
using AutoMarket.Domain.ViewModels.Profile;
using AutoMarket.Domain.ViewModels.User;

namespace AutoMarket.Service.Interfaces
{
    public interface IProfileService
    {
        Task<BaseResponse<ProfileViewModel>> GetProfile(string userName);

        Task<BaseResponse<Profile>> Save(ProfileViewModel model);
    }
}