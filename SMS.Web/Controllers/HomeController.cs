using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

        public IActionResult About()
    {
        var about = new AboutViewModel {
            Title = "Hello World",
            Message = "Welcome to our site",
            Formed = new DateTime(2022,1,1)        
            };    

        return View(about);
    }

    public IActionResult Index()
    {
        var longtime = DateTime.Now.ToLongDateString();
        var message = "Time Now";
   
        // add strongly typed values to ViewBag
        ViewBag.LongTime = longtime;
        ViewBag.Message = message;

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
