using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class PostTagRelation
    {
        [Key]
        public string RelationID { get; set; } = Guid.NewGuid().ToString();

        public string PostID { get; set; } = "";
        public string TagID { get; set; } = "";
    }
}
