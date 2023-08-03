using System.Diagnostics;
using AutoMarket.DAL.Interfaces;
using AutoMarket.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMarket.Models;

namespace AutoMarket.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public Task<IActionResult> Index()
    {
        return Task.FromResult<IActionResult>(View());
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