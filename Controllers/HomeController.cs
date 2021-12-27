using BlogApp.Entities;
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
        private readonly TagRepository _tagRepository;
        private readonly CommentRepository _commentRepository;

        public HomeController(ILogger<HomeController> logger,PostRepository postRepository,CategoryRepository categoryRepository,PostService postService,TagRepository tagRepository,CommentRepository commentRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
            _postService = postService;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
            _commentRepository = commentRepository;
        }

        public IActionResult Index(string id,string type)
        {
            var y = new List<Post>();
            var x = _postService.OrderingPost();
                foreach (var item in x)
                {
                    item.PostComments = _postService.GetComment(item.PostID);
                    item.PostTags = _postService.GetTag(item.PostID);
                }
            
            if (type == "Category")
            {

                foreach (var item in x)
                {
                    if (item.PostCategoryID == id)
                    {
                        y.Add(item);
                        x = y;
                    }

                }
            }
            if (type == "Tag")
            {
                foreach (var item in x)
                {
                    foreach (var tags in item.PostTags)
                    {
                        if (tags.TagID == id)
                        {
                            y.Add(item);
                            x = y;
                        }
                    }
                }
            }
            return View(x);
        }

        public IActionResult Privacy(string id)
        {
            var z = new Post();
            var x = _postService.OrderingPost();
            foreach (var item in x)
            {
                item.PostComments = _postService.GetComment(item.PostID);
                item.PostTags = _postService.GetTag(item.PostID);
                if (item.PostID == id)
                {
                    z = item;
                }
            }


            return View(z);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
