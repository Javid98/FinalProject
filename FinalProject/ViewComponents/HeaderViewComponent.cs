using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<AppUser> _userManager;
		public HeaderViewComponent(ApplicationDbContext db, UserManager<AppUser> userManager)
		{
			_db = db;
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			List<BookInCart> bookInCarts = _db.BookInCarts.Where(bc => bc.AppUserId == user.Id).ToList();
			int count = 0;
			foreach (BookInCart book in bookInCarts)
			{
				count += book.Count;
			}
			ViewBag.BookCount = count;
			return View(await Task.FromResult(bookInCarts));
		}
	}
}
