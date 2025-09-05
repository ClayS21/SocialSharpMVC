using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialSharpMVC.Data;
using SocialSharpMVC.Data.Models;
using SocialSharpMVC.ViewModels.Home;

namespace SocialSharpMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allPosts = await _context.Posts.Include(m => m.User).ToListAsync();
            return View(allPosts);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostVM post)
        {
            int loggedUser = 1;

            var newPost = new Post
            {
                Content = post.Content,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                ImageUrl = "",
                NumOfReports = 0,
                UserId = loggedUser
            };

            await _context.Posts.AddAsync(newPost);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
