using Microsoft.AspNetCore.Identity;

namespace PC_PartsReview_Website.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}