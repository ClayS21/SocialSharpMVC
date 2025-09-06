using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSharpMVC.ViewModels.Home
{
    public class PostVM
    {
        public string Content { get; set; }

        public IFormFile Image { get; set; }
    }
}