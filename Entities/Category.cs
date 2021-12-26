using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Category
    {
        public string CategoryID { get; set; } = Guid.NewGuid().ToString();
        public string CategoryName { get; set; } 

        public List<Post> CategoryPosts { get; set; } // Kategorinin birçok postu olabilir.
    }
}
