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

namespace FinalProject.Controllers
{
	public class BasketController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<AppUser> _userManager;
		public BasketController(ApplicationDbContext db, UserManager<AppUser> userManager)
		{
			_db = db;
			_userManager = userManager;
		}

		[Authorize]
		[Route("Basket/{username}")]
		public async Task<IActionResult> Index(string username)
		{
			if (username == null) return NotFound();
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			if (username != User.Identity.Name) return NotFound();
			List<BookInCart> bookInCarts = _db.BookInCarts.Include(bc => bc.Book).Include(bc => bc.AppUser).OrderBy(bc => bc.Id).Where(bc => bc.AppUserId == user.Id).ToList();
			List<BookAuthor> bookAuthors = _db.BookAuthors.Include(ba => ba.Book).Include(ba => ba.Author).ToList();
			ViewBag.Total = 0;
			foreach (BookInCart bookInCart in bookInCarts)
			{

			}
			BasketVM model = new BasketVM
			{
				BookInCarts = bookInCarts,
				BookAuthors = bookAuthors
			};
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[ActionName("Index")]
		public async Task<IActionResult> Sale()
		{
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			List<BookInCart> bookInCarts = _db.BookInCarts.Include(bc=>bc.Book).Include(bc=>bc.AppUser).OrderBy(bc => bc.Id).Where(bc => bc.AppUserId == user.Id).ToList();
			Sale sale = new Sale();
			double total = 0;
			if (Request.Form["Type"].ToString().ToLower() == "metro")
			{
				sale.Date = DateTime.Now;
				sale.AppUserId = user.Id;
				sale.DeliveryType = Request.Form["Type"];
				sale.DeliveryLocation = Request.Form["Metro"];
			}
			else if (Request.Form["Type"].ToString().ToLower() == "şəhər daxili")
			{
				sale.Date = DateTime.Now;
				sale.AppUserId = user.Id;
				sale.DeliveryType = Request.Form["Type"];
				sale.DeliveryLocation = Request.Form["City"];
				total = 2;
			}
			else if (Request.Form["Type"].ToString().ToLower() == "rayon")
			{
				sale.Date = DateTime.Now;
				sale.AppUserId = user.Id;
				sale.DeliveryType = Request.Form["Type"];
				sale.DeliveryLocation = Request.Form["Region"];
				total = 2;
			}
			List<SaleBook> saleBooks = new List<SaleBook>();
			int i = 0;
			int a;
			foreach (BookInCart bookInCart in bookInCarts)
			{
				if (int.TryParse(Request.Form["Count"][i], out a))
				{

					saleBooks.Add(new SaleBook
					{
						SaleId = sale.Id,
						Count = int.Parse(Request.Form["Count"][i]),
						Price= bookInCart.Book.Price,
						BookId=bookInCart.Book.Id,
						AppUserId=user.Id
					});
					total += bookInCart.Book.Price * int.Parse(Request.Form["Count"][i]);
					i++;
					_db.BookInCarts.Remove(bookInCart);
				}
			}
			sale.Total = total;
			sale.SaleBooks = saleBooks;
			await _db.Sales.AddAsync(sale);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index","Home");

		}
		public async Task<IActionResult> DeleteBook(int? id)
		{
			if (id == null) return NotFound();
			BookInCart bookInCart = _db.BookInCarts.FirstOrDefault(bc => bc.BookId == id);
			_db.BookInCarts.Remove(bookInCart);
			await _db.SaveChangesAsync();
			return RedirectToAction(User.Identity.Name);
		}
	}
}