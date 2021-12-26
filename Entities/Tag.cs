using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Tag
    {
        public string TagID { get; set; } = Guid.NewGuid().ToString();
        public string TagName { get; set; }

        public List<Post> TagPosts { get; set; } = new List<Post>(); // Tag'in birçok postu olabilir
    }
}
