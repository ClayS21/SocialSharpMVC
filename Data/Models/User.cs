namespace SocialSharpMVC.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string? ProfilePictureUrl { get; set; }

        // Navigation properties

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
