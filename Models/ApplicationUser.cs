using Microsoft.AspNetCore.Identity;

namespace HR_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
