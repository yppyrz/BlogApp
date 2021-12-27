using BlogApp.Databae;
using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repositories
{
    public class CategoryRepository
    {
        private readonly BlogAppDbContext _db;

        public CategoryRepository()
        {
            _db = new BlogAppDbContext();
        }

        /// <summary>
        /// Database'e yeni category ekler
        /// </summary>
        /// <param name="category"></param>
        public void AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
        }

        /// <summary>
        /// Database'de bulunan tüm categoryleri liste halinde getirir
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategory()
        {
            return _db.Categories.ToList();
            
        }
    }
}
