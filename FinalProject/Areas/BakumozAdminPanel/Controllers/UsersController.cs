using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
    [Area("BakumozAdminPanel")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public UsersController(ApplicationDbContext db, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
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
        public async Task<IActionResult> Detail(string username)
        {
            if (username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            UserDetail userDetail = _db.UserDetails.Include(ud => ud.AppUser).FirstOrDefault(ud => ud.AppUserId == user.Id);
            return View(userDetail);
        }
    }
}