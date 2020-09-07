using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
    [Area("BakumozAdminPanel")]
    [Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public UsersController(ApplicationDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _db.Users.Where(u=>u.IsBlocked==false).ToList();
            List<UserVM> model = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM newUser = new UserVM
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Fullname = user.FullName,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                model.Add(newUser);
            }
            return View(model);
        }
        [Route("BakumozAdminPanel/Mushteri/{username}")]
        public async Task<IActionResult> Block(string username)
        {
            if (username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            UserDetail userDetail = _db.UserDetails.Include(ud => ud.AppUser).FirstOrDefault(ud => ud.AppUserId == user.Id);
            return View(userDetail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BlockUser(string username)
        {
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            user.IsBlocked = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> BlockedUsers()
        {
            List<AppUser> users = _db.Users.Where(u => u.IsBlocked == true).ToList();
            List<UserVM> model = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM newUser = new UserVM
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Fullname = user.FullName,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                model.Add(newUser);
            }
            return View(model);
        }
        public async Task<IActionResult> RemoveBlock(string username)
        {
            if (username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            user.IsBlocked = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("BlockedUsers");
        }
        [Route("BakumozAdminPanel/Deyish/{username}")]
        public async Task<IActionResult> Edit(string username)
        {
            if (username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            UserVM model = new UserVM
            {
                Fullname = user.FullName,
                Username = user.UserName,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Bio = _db.Bios.FirstOrDefault()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(string username)
        {
            if (username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            var oldRole = (await _userManager.GetRolesAsync(user))[0];
            await _userManager.RemoveFromRoleAsync(user, oldRole);
            string newRole = Request.Form["roles"];
            await _userManager.AddToRoleAsync(user, newRole);
            return RedirectToAction("Index");
        }
    }
}