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
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "at least \n {2} characters.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The passwords do not match.")]
            public string ConfirmPassword { get; set; }
            
            [Required]
            [DataType(DataType.Text)]
            [StringLength(50, ErrorMessage = "at least {2} characters long.", MinimumLength = 2)]
            [Display(Name ="First Name")]
            public string FirstName { get; set; }
            
            [Required]
            [DataType(DataType.Text)]
            [StringLength(50, ErrorMessage = "at least {2} characters.", MinimumLength = 2)]
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
            
            [Display(Name = "Is this account in name of an organisation?")]
            public bool isOrganisation { get; set; }
            
            [DataType(DataType.Text)]
            [MaxLength(30)]
            [Display(Name = "Organisation Name")]
            public string OrganisationName { get; set; }
            
            [Display(Name = "Event Input")]
            [MaxLength(50)]
            [DataType(DataType.Text)]
            public string OrganisationEventInput { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Age = Input.Age,
                    Gender = Input.Gender,
                    PostalCode = Input.PostalCode
                };
                if (Input.isOrganisation)
                {
                    var organisation = new Organisation
                    {
                        OrganisationName = Input.OrganisationName,
                        OrganisationEventInput = Input.OrganisationEventInput,
                        ApplicationUser = user
                    };
                    user.Organisation = organisation;
                }
                var resultUser = await _userManager.CreateAsync(user, Input.Password);
                if (Input.isOrganisation)
                {
                    await _userManager.AddToRoleAsync(user, "SignedInUserOrganisation");
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, "SignedInUser");
                }
                if (resultUser.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in resultUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
