using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string UrlImage { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
    }
}
