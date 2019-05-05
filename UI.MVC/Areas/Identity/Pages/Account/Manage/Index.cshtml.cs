using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BL;
using DAL.EF;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI.MVC.Models;

namespace UI.MVC.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IIdentityManager _imgr;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ApplicationDbContext ctx)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _imgr = new IdentityManager(ctx);
        }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "First name")]
            public string FirstName { get; set; }
            
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Last name")]
            public string LastName { get; set; }
            
            [DataType(DataType.Text)]
            [Display(Name = "Gender")]
            public string Gender { get; set; }
            
            [DataType(DataType.Text)]
            [MaxLength(2)]
            [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
            [Display(Name = "Age")]
            public string Age { get; set; }
            
            [DataType(DataType.Text)]
            [MaxLength(15)]
            [Display(Name = "Postal Code")]
            public string PostalCode { get; set; }
            
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

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);

            Username = userName;

            Input = new InputModel();
            Input.Email = email;
            Input.FirstName = user.FirstName;
            Input.LastName = user.LastName;
            Input.Gender = user.Gender;
            Input.Age = user.Age;
            Input.PostalCode = user.PostalCode;

            if (_imgr.getOrganisation(user.Id) != null)
            {
                Input.isOrganisation = true;
                Input.OrganisationName = _imgr.getOrganisation(user.Id).OrganisationName;
                Input.OrganisationEventInput = _imgr.getOrganisation(user.Id).OrganisationEventInput;
            }

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var email = await _userManager.GetEmailAsync(user);
            if (Input.Email != email)
            {
                var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmailResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{userId}'.");
                }
            }
            
            if (Input.FirstName != user.FirstName)
            {
                user.FirstName = Input.FirstName;
            }
            if (Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
            }
            if (Input.Age != user.Age)
            {
                user.Age = Input.Age;
            }
            if (Input.Gender != user.Gender)
            {
                user.Gender = Input.Gender;
            }
            if (Input.PostalCode != user.PostalCode)
            {
                user.PostalCode = Input.PostalCode;
            }
            if (Input.isOrganisation)
            {
                if (_imgr.getOrganisation(user.Id) == null)
                {
                    var organisation = new Organisation
                    {
                        OrganisationName = Input.OrganisationName,
                        OrganisationEventInput = Input.OrganisationEventInput,
                        ApplicationUser = user
                    };
                    user.Organisation = organisation;
                }
                else if (_imgr.getOrganisation(user.Id) != null)
                {
                    Organisation o = _imgr.getOrganisation(user.Id);
                    o.OrganisationName = Input.OrganisationName;
                    o.OrganisationEventInput = Input.OrganisationEventInput;
                    _imgr.changeOrganisation(o);
                }
                if (_userManager.GetRolesAsync(user).Result.First() == "SignedInUserOrganisation")
                {
                    await _userManager.RemoveFromRoleAsync(user, "SignedInUserOrganisation");
                    await _userManager.AddToRoleAsync(user, "SignedInUser");
                }
            }
            if (!Input.isOrganisation)
            {
                if (_imgr.getOrganisation(user.Id) != null)
                {
                    _imgr.removeOrganisation(_imgr.getOrganisation(user.Id).Id);
                }
                if (_userManager.GetRolesAsync(user).Result.First() == "SignedInUser")
                {
                    await _userManager.RemoveFromRoleAsync(user, "SignedInUser");
                    await _userManager.AddToRoleAsync(user, "SignedInUserOrganisation");
                }
            }
            
            await _userManager.UpdateAsync(user);
            
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }


            var userId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = userId, code = code },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(
                email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            StatusMessage = "Verification email sent. Please check your email.";
            return RedirectToPage();
        }
    }
}
