using System.ComponentModel.DataAnnotations;

namespace Hattfabriken.Models.Viewmodels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Skriv ditt användarnamn.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Skriv ditt lösenord.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
