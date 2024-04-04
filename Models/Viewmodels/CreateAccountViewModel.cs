using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace Hattfabriken.Models.Viewmodels
{
    public class CreateAccountViewModel : IdentityUser
    {
        [Required(ErrorMessage = "Please choose a username")]
        [Display(Name = "Username")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
        [Key]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
