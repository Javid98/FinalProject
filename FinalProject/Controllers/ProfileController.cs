﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _db;
        public ProfileController(UserManager<AppUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        [Route("profil/{username}")]
        public async Task<IActionResult> Index(string username)
        {
            if(username == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound();
            UserDetail userDetail = _db.UserDetails.FirstOrDefault(u => u.AppUserId == user.Id);
            ProfileVM model = new ProfileVM
            {
                UserDetail = userDetail,
                AppUser=user
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SaveChanges(ProfileVM settings)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return NotFound();
            UserDetail userD = _db.UserDetails.FirstOrDefault(u => u.AppUserId == user.Id);
            if (userD == null)
            {
                UserDetail userDetail = new UserDetail();
                userDetail.AppUserId = user.Id;
                user.FullName = settings.AppUser.FullName;
                if (settings.BirthDay != null)
                {
                    DateTime day = DateTime.Now.Date;
                    TimeSpan span = day - settings.BirthDay;
                    int age = (int)(Math.Ceiling(span.TotalDays / 365)) - 1;
                    userDetail.Age = age;
                }
                string gender = Request.Form["Gender"];
                userDetail.Gender = gender;
                if (settings.UserDetail.PhoneNumber != null)
                {
                    userDetail.PhoneNumber = settings.UserDetail.PhoneNumber;
                }
                if (settings.UserDetail.InstagramLink != null)
                {
                    userDetail.InstagramLink = settings.UserDetail.InstagramLink;
                }
                if (settings.UserDetail.FacebookLink != null)
                {
                    userDetail.FacebookLink = settings.UserDetail.FacebookLink;
                }
                _db.UserDetails.Add(userDetail);
                await _db.SaveChangesAsync();
                return RedirectToAction(User.Identity.Name, "profil");
            }
            else
            {
                userD.AppUserId = user.Id;
                user.FullName = settings.AppUser.FullName;
                if (settings.BirthDay != null)
                {
                    DateTime day = DateTime.Now.Date;
                    TimeSpan span = day - settings.BirthDay;
                    int age = (int)(Math.Ceiling(span.TotalDays / 365)) - 1;
                    userD.Age = age;
                }
                string gender = Request.Form["Gender"];
                userD.Gender = gender;
                if (settings.UserDetail.PhoneNumber != null)
                {
                    userD.PhoneNumber = settings.UserDetail.PhoneNumber;
                }
                if (settings.UserDetail.InstagramLink != null)
                {
                    userD.InstagramLink = settings.UserDetail.InstagramLink;
                }
                if (settings.UserDetail.FacebookLink != null)
                {
                    userD.FacebookLink = settings.UserDetail.FacebookLink;
                }
                await _db.SaveChangesAsync();
                return RedirectToAction(User.Identity.Name, "profil");
            }
        }
    }
}