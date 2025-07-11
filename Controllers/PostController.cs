using Microsoft.AppNetCore.Mvs;
using BlogApp.Data;
using BlogApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
  public class PostController : Controller
  {
    private readonly AppDbContext _db;
    public PostController(AppDbContext db)
    {
      _db = db;
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Post post)
    {
      
    }

  }
}