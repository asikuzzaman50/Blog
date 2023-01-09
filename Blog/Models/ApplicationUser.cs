using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class Applicationuser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<Post>? Posts { get; set; }

    }
}
