using AutoMarket.DAL.Interfaces;
using AutoMarket.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMarket.DAL.Repositories;

public class CarRepository : ICarRepository
{
    private readonly ApplicationDbContext _db;

    public CarRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public bool Create(Car entity)
    {
        throw new NotImplementedException();
    }

    public Car Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Car>> Select()
    {
        return await _db.Car.ToListAsync();
    }

    public bool Delete(Car entity)
    {
        throw new NotImplementedException();
    }

    public Car GetByName(string name)
    {
        throw new NotImplementedException();
    }
}