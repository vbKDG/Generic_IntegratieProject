using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using DAL.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UI.MVC.Models;

namespace UI.MVC.Areas.Identity.Pages.Account
{
    [Authorize(Roles="SuperAdmin, Admin")]
    public class CreateModeratorModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<CreateModeratorModel> _logger;

        public CreateModeratorModel(
            UserManager<ApplicationUser> userManager,
            ILogger<CreateModeratorModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            
            [Required]
            [DataType(DataType.Text)]
            [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
            [Display(Name ="First Name")]
            public string FirstName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [DataType(DataType.Text)]
            [MaxLength(15)]
            [Display(Name = "Postal Code")]
            public string PostalCode { get; set; }

            [DataType(DataType.Text)]
            [MaxLength(2)]
            [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
            public string Age { get; set; }

            [DataType(DataType.Text)]
            [MaxLength(1)]
            public string Gender { get; set; }
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            var returnUrl = "~/Admin/ManageModerators";
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    EmailConfirmed = true,
                    Age = Input.Age,
                    Gender = Input.Gender,
                    PostalCode = Input.PostalCode,
                };
                var resultUser = await _userManager.CreateAsync(user, Input.Password);
                
                if (resultUser.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Moderator");
                    _logger.LogInformation("Super Admin / Admin created a new Moderator account with password.");
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in resultUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return LocalRedirect(returnUrl);
            }
            return Page();
        }
    }
}
