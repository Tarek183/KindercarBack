using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string ContentComment { get; set; }
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }
        public int LikeComment { get; set; }
        public int DislikeComment { get; set; }
    }
}
