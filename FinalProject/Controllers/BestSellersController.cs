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

namespace FinalProject.Controllers
{
	public class BestSellersController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<AppUser> _userManager;
		public BestSellersController(ApplicationDbContext db, UserManager<AppUser> userManager)
		{
			_db = db;
			_userManager = userManager;
		}
		public async Task<IActionResult> Index(int page = 1)
		{
			ViewBag.Page = page;
			List<Book> books = _db.Books.Include(b=>b.BookAuthors).ThenInclude(b=>b.Author).Include(b=>b.BookCategories).Include(b=>b.Publisher).OrderByDescending(b => b.SaleCount).Take(100).ToList();
			ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
			List<Book> bestSellers = books.Skip((page - 1) * 10).Take(10).ToList();
			//List<BookAuthor> bookAuthors = _db.BookAuthors.ToList();
			//List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
			//List<Publisher> publishers = _db.Publishers.OrderByDescending(n => n.BookCount).ToList();
			//List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();
			ViewBag.Currency = _db.Bios.FirstOrDefault().Currency;
			AppUser user = new AppUser();
			if (User.Identity.IsAuthenticated)
			{
				user = await _userManager.FindByNameAsync(User.Identity.Name);
			}
			List<BookInCart> bookInCarts = new List<BookInCart>();
			List<FavoriteBook> favoriteBooks = new List<FavoriteBook>();
			if (user != null)
			{
				bookInCarts = _db.BookInCarts.Include(bc => bc.Book).Include(bc => bc.AppUser).Where(bc => bc.AppUserId == user.Id).ToList();
				favoriteBooks = _db.FavoriteBooks.Include(bc => bc.Book).Include(bc => bc.AppUser).Where(bc => bc.AppUserId == user.Id).ToList();
			}
			NewBooksVM model = new NewBooksVM
			{
				Books = bestSellers,
				AllBooks=books,
				//BookAuthors = bookAuthors,
				//Authors = authors,
				//Publishers = publishers,
				//Categories = categories,
				BookInCarts = bookInCarts,
				FavoriteBooks = favoriteBooks
			};
			return View(model);
		}
	}
}