﻿using BlogApp.Entities;
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
    public class model
    {
        private readonly PostRepository _postRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly PostService _postService;
        private readonly TagRepository _tagRepository;
        public model(PostRepository postRepository, CategoryRepository categoryRepository, PostService postService, TagRepository tagRepository)
        {
            posts = _postService.OrderingPost();
            categories = _categoryRepository.GetAllCategory();
            tags = _tagRepository.GetAllTag();
        }
        public List<Post> posts { get; set; }
        public List<Category> categories { get; set; }
        public List<Tag> tags { get; set; }

    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostRepository _postRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly PostService _postService;
        private readonly TagRepository _tagRepository;

        public HomeController(ILogger<HomeController> logger,PostRepository postRepository,CategoryRepository categoryRepository,PostService postService,TagRepository tagRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
            _postService = postService;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
        }

        public IActionResult Index()
        {
            

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
}
