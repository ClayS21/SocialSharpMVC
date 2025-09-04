using System.ComponentModel.DataAnnotations;

namespace SocialSharpMVC.Data.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public string Content { get; set; }

        public string? ImageUrl { get; set; }

        public int NumOfReports { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
