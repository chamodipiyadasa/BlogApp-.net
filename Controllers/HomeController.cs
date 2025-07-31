using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

// /Controllers/HomeController.cs
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
