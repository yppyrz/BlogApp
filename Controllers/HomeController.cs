using BlogApp.Models;
using BlogApp.Repositories;
using BlogApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostRepository _postRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly PostService _postService;

        public HomeController(ILogger<HomeController> logger,PostRepository postRepository,CategoryRepository categoryRepository,PostService postService)
        {
            _logger = logger;
            _postRepository = postRepository;
            _postService = postService;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var model = _postService.OrderingPost();
            return View(model);
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
}
