using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Agri_Energy_Prototype_Project.Models
{
    /// <summary>
    /// The changes that occured in this template code are in the Register method
    /// because the parameters need to match with the database table, 'Users'colomns. 
    ///  public IList<SelectListItem> UserTypeOptions has been added for users
    ///  to be able to pick their role, a Farmer or Employee
    /// </summary>
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

    public class RegisterViewModel
    {
        /// <summary>
        /// RegisterViewModel method has parameter that match the table colom headings
        /// of 'Users' becuase the user needs to register and their data must be saved 
        /// </summary>

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        //------------------------------------------------------------------

        [Required]

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        //-----------------------------------------------------------------

        [Required]

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        //------------------------------------------------------------------------


        [Required]

        [Display(Name = "Age")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }
        //---------------------------------------------------------------------------------


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        //---------------------------------------------------------------------------------
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //------------------------------------------------------------------------------------

        [Required]
        [Display(Name = "User Type")]
        public string SelectedUserType { get; set; }
       


        public IList<SelectListItem> UserTypeOptions { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Farmer" },
            new SelectListItem {  Text = "Employee" }
        };

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
            [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
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

