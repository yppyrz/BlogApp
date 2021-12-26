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
    [ViewComponent(Name = "Category")]
    public class CategoryViewComponent:ViewComponent
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly CategoryService _categoryService;

        public CategoryViewComponent(CategoryRepository categoryRepository,CategoryService categoryService)
        {
            _categoryRepository = categoryRepository;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = _categoryRepository.GetAllCategory();
            var model = new List<CategoryViewModel>();

            foreach (var item in categoryList)
            {
                var category = new CategoryViewModel
                {
                    CategoryID = item.CategoryID,
                    CategoryName = item.CategoryName
                };
                model.Add(category);
            }
            return View(await Task.FromResult(model));
        }
    }
}
