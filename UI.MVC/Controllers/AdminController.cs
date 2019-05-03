using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult ManageAdmins()
        {
            var usersOfRole =  _userManager.GetUsersInRoleAsync("Admin");
            return View(usersOfRole);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult EditAdminPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult EditModeratorPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult DeleteAdminPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult DeleteModeratorPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult ManageModerators()
        {
            var usersOfRole =  _userManager.GetUsersInRoleAsync("Moderator");
            return View(usersOfRole);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult EditUser(IFormCollection formCollection)
        {
            IList<string> list = new List<string>();
            ApplicationUser user = new ApplicationUser();
            foreach (var key in formCollection.Keys)
            {
                if (key == "Id")
                {
                    user = _userManager.FindByIdAsync(formCollection[key]).Result;
                    list = _userManager.GetRolesAsync(user).Result;
                }
            }
            foreach (var key in formCollection.Keys)
            {
                switch (key)
                {
                    case "FirstName":
                        user.FirstName = formCollection[key];
                        break;
                    case "LastName":
                        user.LastName = formCollection[key];
                        break;
                    case "Age":
                        user.Age = formCollection[key];
                        break;
                    case "Email":
                        user.Email = formCollection[key];
                        break;
                    case "Gender":
                        user.Gender = formCollection[key];
                        break;
                    case "PostalCode":
                        user.PostalCode = formCollection[key];
                        break;
                }
            }
            _userManager.UpdateAsync(user);
            if (list[0] == "Admin")
            {
                return LocalRedirect("~/Admin/ManageAdmins");
            }
            if (list[0] == "Moderator")
            {
                return LocalRedirect("~/Admin/ManageModerators");
            }
            return RedirectToAction("Index","Home");
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult DeleteUser(IFormCollection formCollection)
        {
            IList<string> list = new List<string>();
            foreach (var key in formCollection.Keys)
            {
                if (key == "Id")
                {
                    ApplicationUser user = _userManager.FindByIdAsync(formCollection[key]).Result;
                    list = _userManager.GetRolesAsync(user).Result;
                    _userManager.DeleteAsync(_userManager.FindByIdAsync(formCollection[key]).Result);
                }
            }
            if (list[0] == "Admin")
            {
                return LocalRedirect("~/Admin/ManageAdmins");
            }   
            if (list[0] == "Moderator")
            {
                return LocalRedirect("~/Admin/ManageModerators");
            }
            
            return RedirectToAction("Index","Home");
        }
    }
}