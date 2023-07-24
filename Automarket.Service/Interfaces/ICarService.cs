using AutoMarket.Domain.Models;
using AutoMarket.Domain.Response;
using AutoMarket.Domain.ViewModels.Car;

namespace Automarket.Service.Interfaces;

public interface ICarService
{
    Task<IBaseResponse<IEnumerable<Car>>> GetCars();

    Task<IBaseResponse<Car>> GetCar(int id);

    Task<IBaseResponse<Car>> GetByName(string name);

    Task<IBaseResponse<bool>> DeleteCar(int id);

    Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);

    Task<IBaseResponse<Car>> Edit(int id, CarViewModel carViewModel);
}