using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Dlusion.Entities
{
    public class Comment
    {
        [Key]
        public long CommentId { get; set; }
        public int UserId { get; set; }
        public string CommentMessage { get; set; }
        public DateTime TimePublished { get; set; }
    }
}
