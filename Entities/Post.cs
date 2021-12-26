using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Post
    {
        public string PostID { get; set; } = Guid.NewGuid().ToString();
        public string PostContent { get; set; } // Post içeriği
        public string PostTitle { get; set; } // Post başlığı
        public string PostAuthorName { get; set; } // Post yazarının adı

        public string PostCategoryID { get; set; } // Postun içeriğinin uygun olduğu kategori. Postun sadece bir adet kategorisi olabilir
        public string PostCategoryName { get; set; }
        public List<Tag> PostTags { get; set; } = new List<Tag>(); // Postun birçok tagi olabilir
        public List<Comment> PostComments { get; set; } = new List<Comment>(); // Postun birçok commenti olabilir

        public List<string> PostTagList { get; set; } = new List<string>();

        public DateTime PostPublishDate { get; set; } // Postun yayımlandığı tarih 
    }
}
