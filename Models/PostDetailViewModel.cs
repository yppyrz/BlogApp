using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class PostDetailViewModel
    {
        public string PostID { get; set; } = Guid.NewGuid().ToString();
        public string PostContent { get; set; } // Post içeriği
        public string PostTitle { get; set; } // Post başlığı
        public string PostAuthorName { get; set; } // Post yazarının adı

        public Category PostCategory { get; set; } // Postun içeriğinin uygun olduğu kategori. Postun sadece bir adet kategorisi olabilir
        public List<Tag> PostTags { get; set; } // Postun birçok tagi olabilir
        public List<Comment> PostComments { get; set; } // Postun birçok commenti olabilir

        public DateTime PostPublishDate { get; set; } // Postun yayımlandığı tarih 
    }
}
