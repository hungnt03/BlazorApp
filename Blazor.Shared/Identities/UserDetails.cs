using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Shared.Identities
{
    public class UserDetails
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
