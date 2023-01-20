
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using car.Models;
using BLL;
using BOL;
namespace car.Controllers;

public class CarController : Controller
{
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        
        CarManager sm=new CarManager();
        List<Car> sl=sm.GetCarsData();
        this.ViewData["List"]=sl;
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
