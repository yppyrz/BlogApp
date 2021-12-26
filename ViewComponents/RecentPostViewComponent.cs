using BlogApp.Entities;
using BlogApp.Models;
using BlogApp.Repositories;
using BlogApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.ViewComponents
{
    [ViewComponent (Name ="RecentPost")]
    public class RecentPostViewComponent:ViewComponent
    {
        private readonly PostRepository _postRepository;
        private readonly PostService _postService;

        public RecentPostViewComponent(PostRepository postRepository,PostService postService)
        {
            _postRepository = postRepository;
            _postService = postService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recentPost = _postService.OrderingPost().Take(4); // Sıralanmış postlardan 4 tanesini getirir
            var model = new List<RecentPostViewModel>(); 

            foreach (var item in recentPost)
            {
                var post = new RecentPostViewModel // Oluşturulan ViewModel doldurulur
                {
                    PostID = item.PostID,
                    PostTitle = item.PostTitle,
                    PublishDate = item.PostPublishDate

                };
                model.Add(post);
            }

            return View(await Task.FromResult(model)); // ViewComponent view a return edilir
        }

    }
}
