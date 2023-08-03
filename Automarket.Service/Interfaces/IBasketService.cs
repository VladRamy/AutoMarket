using AutoMarket.Domain.Response;
using AutoMarket.Domain.ViewModels.Order;

namespace AutoMarket.Service.Interfaces
{
    public interface IBasketService
    {
        Task<IBaseResponse<IEnumerable<OrderViewModel>>> GetItems(string userName);

        Task<IBaseResponse<OrderViewModel>> GetItem(string userName, long id);
    }   
}