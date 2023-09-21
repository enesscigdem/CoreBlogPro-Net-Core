using System;
using Microsoft.AspNetCore.Identity;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("2eff5f4b-13ae-4140-a98c-9df62488ce7e");
        public Image Image{ get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}

