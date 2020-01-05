using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatingWebsite.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //REGISTER NEW USER
    public class RegisterViewModel 
    {
        //USERNAME, EMAIL
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //FORNAME
        [Required]
        [MinLength(1,ErrorMessage = "mininum 1 character required.") ]
        //[StringLength(100, "The {0} must be at least {2} characters long.", MinimunLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Forname")]
        public string Forname { get; set; }

        //SURNAME
        [Required]
        [MinLength(1, ErrorMessage = "mininum 1 character required.")]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimunLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Surname")]
        public string Surname { get; set; }        

        //PASSWORD
        [Required]
        [StringLength(100, ErrorMessage = "mininum 6 character required.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //CONFIRM PASSWORD
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        
        //GENDER
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        
        //AGE
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime? DateOfBirth { get; set; }

        ////PROFILEPICTURE
        //[DataType(DataType.ImageUrl)]
        //[Display(JAGVETINTE = "Profile Picture")]
        //public string ProfilePicture { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
