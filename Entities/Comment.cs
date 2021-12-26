using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Comment
    {
        public string CommentID { get; set; } = Guid.NewGuid().ToString();
        public string CommentContent { get; set; } // Comment içeriği
        public string UserName { get; set; } // Comment'i atan kişi

        public Post CommentPost { get; set; } // Comment'in sadece bir tane postu olabilir
        public DateTime CommentPublishDate { get; set; } // Comment'in atıldığı tarih
    }
}
