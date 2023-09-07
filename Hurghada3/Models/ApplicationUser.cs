using Microsoft.AspNetCore.Identity;

namespace Hurghada3.Models
{
    public class ApplicationUser:IdentityUser
    {
        
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;
        public byte[] ProfilePicture { get; set; } = new byte[0];
    }
}
