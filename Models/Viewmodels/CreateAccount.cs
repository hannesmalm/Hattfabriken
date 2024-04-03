using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace Hattfabriken.Models.Viewmodels
{
    public class CreateAccount : IdentityUser
    {
        [Required(ErrorMessage = "Vänligen välj ett användarnamn")]
        [Display(Name = "Användarnamn")]
        [MinLength(3, ErrorMessage = "Användarnamnet måste vara minst 3 tecken långt.")]
        [Key]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett lösenord")]
        [Display(Name = "Lösenord")]
        [MinLength(6, ErrorMessage = "Lösenordet måste vara minst 6 tecken långt.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
