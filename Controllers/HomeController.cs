using System.Diagnostics;

using BlogApp.Models;

namespace BlogApp.Controllers;

using BlogApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly AppDbContext _db;

    public HomeController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var recentPosts = _db.Posts
            .OrderByDescending(p => p.CreatedAt)
            .Take(5)
            .ToList();

        return View(recentPosts);
    }
}
