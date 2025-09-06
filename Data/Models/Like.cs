using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSharpMVC.Data.Models
{
    public class Like
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        // Navigation properties

        public Post Post { get; set; }

        public User User { get; set; }
    }
}