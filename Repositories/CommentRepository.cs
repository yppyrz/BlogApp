using BlogApp.Databae;
using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repositories
{
    public class CommentRepository
    {
        private readonly BlogAppDbContext _db;

        public CommentRepository()
        {
            _db = new BlogAppDbContext();
        }

        /// <summary>
        /// Database'e comment ekler
        /// </summary>
        /// <param name="comment"></param>
        public void AddCommnet(Comment comment)
        {
            _db.Comments.Add(comment);
            _db.SaveChanges();
        }
    }
}
