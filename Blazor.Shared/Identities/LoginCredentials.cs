using System.ComponentModel.DataAnnotations;

namespace Blazor.Shared.Identities
{
    public class LoginCredentials
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
