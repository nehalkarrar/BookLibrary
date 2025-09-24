using Microsoft.AspNetCore.Identity;

namespace BookLibrary.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
