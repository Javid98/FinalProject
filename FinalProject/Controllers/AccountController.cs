using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Helpers;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ApplicationDbContext _db;
        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountVM register)
        {
            if (ModelState["Fullname"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid ||
                ModelState["RegisterUsername"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid || ModelState["Email"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid ||
                ModelState["RegisterPassword"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid ||
                ModelState["ConfirmPassword"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid) return PartialView("_RegisterPartialView", register);
            AppUser user = new AppUser
            {
                FullName = register.Fullname,
                UserName = register.RegisterUsername,
                Email=register.Email
            };
            IdentityResult identityResult = await _userManager.CreateAsync(user, register.RegisterPassword);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return PartialView("_RegisterPartialView");
            }
            UserDetail userDetail = new UserDetail
            {
                AppUserId = user.Id
            };
            _db.UserDetails.Add(userDetail);
            await _userManager.AddToRoleAsync(user, Helper.Roles.Member.ToString());
            await _signInManager.SignInAsync(user, false);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginP(AccountVM login)
        {
            if (ModelState["LoginUsername"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid ||
                ModelState["LoginPassword"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid
                ) return PartialView("_LoginPartialView", login);
            AppUser logUser = await _userManager.FindByNameAsync(login.LoginUsername);
            if (logUser == null)
            {
                ModelState.AddModelError("", "Username və ya şifrə yanlışdır");
                return PartialView("_LoginPartialView",login);
            }
            if (logUser.IsBlocked == true)
            {
                ModelState.AddModelError("", "Bu profil bloklanıb");
                return PartialView("_LoginPartialView");
            }
            if (login.IsChecked == true)
            {
                Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(logUser, login.LoginPassword, true, true);
                if (!signInResult.Succeeded)
                {
                    ModelState.AddModelError("", "Username və ya şifrə yanlışdır");
                    return PartialView("_LoginPartialView", login);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(logUser, login.LoginPassword, false, true);
                if (!signInResult.Succeeded)
                {
                    ModelState.AddModelError("", "Username və ya şifrə yanlışdır");
                    return PartialView("_LoginPartialView", login);
                }
                return RedirectToAction("Index", "Home");
            }

        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task CreateRole()
        {
            if (!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Helper.Roles.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Member.ToString()));
            }
        }
    }
}