using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSharpMVC.ViewModels.Home
{
    public class PostCommentVM
    {
        public int PostId { get; set; }

        public string Content { get; set; }
    }
}