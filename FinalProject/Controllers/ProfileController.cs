using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Extentions;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly ApplicationDbContext _db;
		private readonly IHostingEnvironment _env;
		public ProfileController(UserManager<AppUser> userManager, ApplicationDbContext db, IHostingEnvironment env)
		{
			_userManager = userManager;
			_db = db;
			_env = env;
		}
		[Route("profil/{username}")]
		public async Task<IActionResult> Index(string username)
		{
			if (username == null) return NotFound();
			AppUser user = await _userManager.FindByNameAsync(username);
			if (user == null) return NotFound();
			UserDetail userDetail = _db.UserDetails.FirstOrDefault(u => u.AppUserId == user.Id);
			ViewBag.Age = "";
			if (userDetail.Birthday.Year != 1)
			{
				DateTime day = DateTime.Now.Date;
				TimeSpan span = day - userDetail.Birthday;
				ViewBag.Age = (int)(Math.Ceiling(span.TotalDays / 365)) - 1;
				int age = ViewBag.Age;
			}
			List<FavoriteBook> favoriteBooks = _db.FavoriteBooks.Include(fb => fb.Book).Include(fb => fb.AppUser).Where(fb => fb.AppUserId == user.Id).ToList();
			List<BookAuthor> bookAuthors = _db.BookAuthors.Include(ba => ba.Author).Include(ba => ba.Book).ToList();
			List<Publisher> publishers = _db.Publishers.ToList();
			List<Sale> sales = _db.Sales.Include(s => s.SaleBooks).Where(s => s.AppUserId == user.Id).ToList();
			List<SaleBook> saleBooks = _db.SaleBooks.Include(sb => sb.Book).Where(s => s.AppUserId == user.Id).ToList();
			ProfileVM model = new ProfileVM
			{
				UserDetail = userDetail,
				AppUser = user,
				FavoriteBooks = favoriteBooks,
				BookAuthors = bookAuthors,
				Publishers = publishers,
				Sales = sales,
				SaleBooks = saleBooks
			};
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> SaveChanges(ProfileVM settings)
		{
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			UserDetail userD = _db.UserDetails.FirstOrDefault(u => u.AppUserId == user.Id);
			ViewBag.Age = "";
			user.FullName = settings.AppUser.FullName;
			if (settings.UserDetail.Birthday != null && settings.UserDetail.Birthday.Year != 1)
			{
				userD.Birthday = settings.UserDetail.Birthday;

			}
			string gender = Request.Form["Gender"];
			userD.Gender = gender;
			if (settings.UserDetail.PhoneNumber != null)
			{
				userD.PhoneNumber = settings.UserDetail.PhoneNumber;
			}
			userD.InstagramLink = settings.UserDetail.InstagramLink;
			userD.FacebookLink = settings.UserDetail.FacebookLink;

			await _db.SaveChangesAsync();
			return RedirectToAction(User.Identity.Name, "profil");
		}
		[HttpPost]
		public async Task<IActionResult> ChangePhoto(ProfileVM change)
		{
			if (change.Photo == null)
			{
				return RedirectToAction(User.Identity.Name, "profil");
			}
			if (!change.Photo.IsImage())
			{
				ModelState.AddModelError("", "Sadəcə şəkil seçə bilərsiz");
				return PartialView("_RegisterPartialView");
			}
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			UserDetail userD = _db.UserDetails.FirstOrDefault(u => u.AppUserId == user.Id);
			if (userD == null)
			{
				UserDetail userDetail = new UserDetail();
				userDetail.AppUserId = user.Id;
				userDetail.ImagePath = await change.Photo.SaveImg(_env.WebRootPath, "image", "usersphotos");
				_db.UserDetails.Add(userDetail);
				await _db.SaveChangesAsync();
				return RedirectToAction(User.Identity.Name, "profil");
			}
			else
			{
				if (userD.ImagePath == null)
				{
					userD.ImagePath = await change.Photo.SaveImg(_env.WebRootPath, "image", "usersphotos");
					await _db.SaveChangesAsync();
					return RedirectToAction(User.Identity.Name, "profil");
				}
				else
				{
					Helpers.Helper.DeleteImg(_env.WebRootPath, "image", "usersphotos", userD.ImagePath);
					userD.ImagePath = await change.Photo.SaveImg(_env.WebRootPath, "image", "usersphotos");
					await _db.SaveChangesAsync();
					return RedirectToAction(User.Identity.Name, "profil");
				}
			}
		}
		public async Task<IActionResult> DeleteFavorite(int? id)
		{
			if (id == null) return NotFound();
			Book book = await _db.Books.FindAsync(id);
			if (book == null) return NotFound();
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			FavoriteBook favoriteBook = _db.FavoriteBooks.FirstOrDefault(fb => fb.AppUserId == user.Id && fb.BookId == book.Id);
			_db.FavoriteBooks.Remove(favoriteBook);
			await _db.SaveChangesAsync();
			return RedirectToAction(User.Identity.Name, "profil");
		}
		public async Task<IActionResult> DeleteFavorites()
		{
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			List<FavoriteBook> favoriteBooks = _db.FavoriteBooks.Where(fb => fb.AppUserId == user.Id).ToList();
			foreach (FavoriteBook favoriteBook in favoriteBooks)
			{
				_db.FavoriteBooks.Remove(favoriteBook);
			}
			await _db.SaveChangesAsync();
			return RedirectToAction(User.Identity.Name, "profil");
		}
	}
}