using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Firstmvc.Models;

namespace Firstmvc.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }
      [HttpGet]
public IActionResult Validate(string email,string password)
    {
        if(email=="kunalbuwa8998@gmail.com" && password=="kunal")
        {
             Console.WriteLine("login Successfull");
            return Redirect ("/Auth/Admin");
        }
        return View();
    }
       public IActionResult Admin()
    {
        return View();
    }
}