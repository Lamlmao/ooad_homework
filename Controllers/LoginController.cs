using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ooad_homework.Models;
using ooad_homework.Services;

namespace ooad.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private List<LoginDTO> loginDTOs = LoginService.Data ; 

    public LoginController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(LoginDTO loginDTO)
    {
        var check = loginDTOs.Where(p => p.UserName == loginDTO.UserName && p.Password == loginDTO.Password).FirstOrDefault() != null ? true : false ; 
        if(check == true){
            this.HttpContext.Session.SetString("User" , loginDTO.UserName);
        }
        return RedirectToAction("index","home");
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

public class LoginDTO { 
    public string UserName { get; set;}
    public string Password { get; set;} 
}