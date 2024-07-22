using System.ComponentModel.DataAnnotations;

namespace DbRelationshipMgmt.Models
{
    public class SignupUserModel
    {
        [Required(ErrorMessage = "Please Enter ur mail id")]
        [Display(Name = "Email Address")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Please Enter ur Name")]
        [Compare("confirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter confirm ur password")]
        [Display(Name = "Confirm Password")]
        public string confirmPassword {  get; set; }
    }
}
