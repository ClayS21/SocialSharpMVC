using SocialSharpMVC.Data.Models;

namespace SocialSharpMVC.Data
{
    public static class Seed
    {
        public static async Task SeedAsync(AppDbContext appDbContext)
        {
            if (!appDbContext.Users.Any() && !appDbContext.Posts.Any())
            {
                var newUser = new User()
                {
                    FullName = "Cleiton Siqueira",
                    ProfilePictureUrl = "https://avatars.githubusercontent.com/u/75696663?v=4"
                };
                await appDbContext.Users.AddAsync(newUser);
                await appDbContext.SaveChangesAsync();

                var newPostNoImage = new Post()
                { 
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin non erat lectus. Suspendisse vel enim sapien. Sed vulputate, nisl non rutrum tempor, est arcu lobortis urna, sodales malesuada quam est pulvinar urna. Nunc posuere, quam non mattis pretium, dui nibh vestibulum sapien, vel fermentum dui augue eget ligula. Proin pharetra eget justo et tempor. Nam iaculis pharetra consectetur. Duis ullamcorper neque velit, ut mollis nunc luctus vel.",
                    ImageUrl = "",
                    NumOfReports = 0,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UserId = newUser.Id
                };

                var newPostWithImage = new Post()
                {
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin non erat lectus. Suspendisse vel enim sapien. Sed vulputate, nisl non rutrum tempor, est arcu lobortis urna, sodales malesuada quam est pulvinar urna. Nunc posuere, quam non mattis pretium, dui nibh vestibulum sapien, vel fermentum dui augue eget ligula. Proin pharetra eget justo et tempor. Nam iaculis pharetra consectetur. Duis ullamcorper neque velit, ut mollis nunc luctus vel.",
                    ImageUrl = "https://unsplash.com/photos/a-river-running-through-a-forest-filled-with-lots-of-trees-zHlQOfEA4V0",
                    NumOfReports = 0,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UserId = newUser.Id
                };

                await appDbContext.Posts.AddRangeAsync(newPostNoImage,  newPostWithImage);
                await appDbContext.SaveChangesAsync();
            }
        }
    }
}
