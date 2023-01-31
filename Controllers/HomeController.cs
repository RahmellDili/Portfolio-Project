using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Poetfolio.Models;
using Portfolio.Service;

namespace Poetfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Gallery()
    {
        return View();
    }

    public IActionResult CyberSecurity()
    {
        return View();
    }

    public IActionResult OOP()
    {
        return View();
    }

    public IActionResult Software()
    {
        return View();
    }


    public IActionResult ContactMe(string name, string email, string message)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        ContactService.SendMessage(name, email, message);

        return RedirectToAction("Thank You");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

