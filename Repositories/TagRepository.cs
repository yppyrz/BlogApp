using BlogApp.Databae;
using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repositories
{
    public class TagRepository
    {
        private readonly BlogAppDbContext _db;

        public TagRepository()
        {
            _db = new BlogAppDbContext();
        }

        /// <summary>
        /// Database'e yeni bir tag ekler
        /// </summary>
        /// <param name="tag"></param>
        public void AddTag(Tag tag)
        {
            _db.Tags.Add(tag);
            _db.SaveChanges();
        }

        /// <summary>
        /// Database'de bulunan tüm tagleri liste olarak getirir
        /// </summary>
        /// <returns></returns>
        public List<Tag> GetAllTag()
        {
            return _db.Tags.ToList();
            
        }

        public Tag FindTag(string Id)
        {
            return _db.Tags.Find(Id);
        }
    }
}
