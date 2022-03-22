using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DressUp.Infrastructure.Data.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string? AccountUsername { get; set; }
    }
}
