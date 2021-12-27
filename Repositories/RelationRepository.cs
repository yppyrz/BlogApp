using BlogApp.Databae;
using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repositories
{
    public class RelationRepository
    {
        private readonly BlogAppDbContext _db;

        public RelationRepository()
        {
            _db = new BlogAppDbContext();

        }

        public List<PostTagRelation> GetAll()
        {
            return _db.Relations.ToList();
        }
    }
}
