using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.BakumozAdminPanel.ViewComponents
{
	public class AdminHeaderViewComponent:ViewComponent
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<AppUser> _userManager;
		public AdminHeaderViewComponent(ApplicationDbContext db, UserManager<AppUser> userManager)
		{
			_db = db;
			_userManager = userManager;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			List<Contact> contacts = _db.Contacts.Where(c=>c.Read==false).OrderByDescending(c => c.Date).ToList();
			List<Sale> sales = _db.Sales.Include(s=>s.AppUser).Where(s => s.Completed == false).OrderByDescending(s => s.Date).ToList();
			Bio bio = _db.Bios.FirstOrDefault();
			UserDetail userDetail = new UserDetail();
			if (User.Identity.IsAuthenticated)
			{
				AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
				userDetail = _db.UserDetails.FirstOrDefault(ud => ud.AppUserId == user.Id);
			}
			AdminVM model = new AdminVM
			{
				Contacts = contacts,
				Sales = sales,
				Bio = bio,
				UserDetail=userDetail
			};
			return View(await Task.FromResult(model));
		}
	}
}
