using Microsoft.AspNetCore.Mvc;
using BlogApp.Data;
using BlogApp.Models;
using System.Linq;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _db;

        public PostController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var posts = _db.Posts.OrderByDescending(p => p.CreatedAt).ToList();
            return View(posts);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                _db.Posts.Add(post);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        public IActionResult Edit(int id)
        {
            var post = _db.Posts.Find(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            _db.Posts.Update(post);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var post = _db.Posts.Find(id);
            _db.Posts.Remove(post);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var post = _db.Posts.Find(id);
            return View(post);
        }
    }
}
