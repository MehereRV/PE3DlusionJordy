using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Dlusion.Entities
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string Lastname { get; set; }
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Required, MaxLength(100)]
        public string EmailAddress { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(7)]
        public string Color { get; set; }

        ICollection<Comment> Comments { get; set; }
    }
}
