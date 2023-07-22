using System.Diagnostics;
using AutoMarket.DAL.Interfaces;
using AutoMarket.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMarket.Models;

namespace AutoMarket.Controllers;

public class HomeController : Controller
{
    private readonly ICarRepository _carRepository;
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ICarRepository carRepository)
    {
        _logger = logger;
        _carRepository = carRepository;
    }

    public async Task<IActionResult> Index()
    {
        var response = await _carRepository.Select();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}