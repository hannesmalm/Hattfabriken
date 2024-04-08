using System.ComponentModel.DataAnnotations;


namespace Hattfabriken.Models.Viewmodels
{
    public class CreateAccountViewModel
    {

        [Required(ErrorMessage = "Please choose a username")]
        [Display(Name = "Username")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }


    }



}