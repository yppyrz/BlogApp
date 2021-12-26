using BlogApp.Databae;
using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repositories
{
    public class PostRepository
    {
        private readonly BlogAppDbContext _db;

        public PostRepository()
        {
            _db = new BlogAppDbContext();
        }

        /// <summary>
        /// Database'e yeni bir post ekler
        /// </summary>
        /// <param name="post"></param>
        public void AddPost(Post post)
        {
            _db.Posts.Add(post);
            _db.SaveChanges();
        }

        /// <summary>
        /// Database'de bulunan postu günceller
        /// </summary>
        /// <param name="post"></param>
        public void UpdatePost(Post post)
        {
            _db.Posts.Update(post);
            _db.SaveChanges();
        }

        /// <summary>
        /// Id'si verilen postu databaseden bulur
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Post FindPost(string Id)
        {
            return _db.Posts.Find(Id);
        }

        /// <summary>
        /// Database'de bulunan tüm postları liste halinde getirir
        /// </summary>
        /// <returns></returns>
        public List<Post> GetAllPost()
        {
            return _db.Posts.ToList();
        }
    }
}
