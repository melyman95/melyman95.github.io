using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ParadigmPetProfessionals.Models;

namespace ParadigmPetProfessionals.Controllers;

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

    public IActionResult Dogs()
    {
        return View();
    }

    public IActionResult Cats()
    {
        return View();
    }

    public IActionResult Fish()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
