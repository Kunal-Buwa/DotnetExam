using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Car.Models;
using System.Collections.Generic;

namespace Car.Controllers;

public class CarsController:Controller
{
     private readonly ILogger<CarsController> _logger;

      public CarsController(ILogger<CarsController> logger)
    {
        Console.WriteLine("Products Controller instance initialized......");
        _logger = logger;
    }
    public IActionResult Index(){
        //fetch data from Model
        //send list of products to ViewData Collection
        
        List<Cars>  allcars=Carmanager.GetAllCars();
        ViewData["catalog"]=allcars;
        return View();
    }
}