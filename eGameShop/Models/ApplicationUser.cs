using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eGameShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
