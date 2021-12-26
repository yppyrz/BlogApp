using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class RecentPostViewModel
    {
        public string PostID { get; set; }
        public string PostTitle { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
