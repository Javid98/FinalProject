﻿using System;
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
		public async Task<IActionResult> Index(string username)
		{
			if (username == null) return NotFound();
			if (username.ToLower().Trim() != User.Identity.Name.ToLower().Trim()) return NotFound();
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			List<BookInCart> bookInCarts = _db.BookInCarts.Include(bc => bc.Book).ThenInclude(b=>b.BookAuthors).ThenInclude(ba=>ba.Author).Include(bc=>bc.Book).ThenInclude(b=>b.Publisher).Include(bc => bc.AppUser).OrderBy(bc => bc.Id).Where(bc => bc.AppUserId == user.Id).ToList();
			//List<BookAuthor> bookAuthors = _db.BookAuthors.Include(ba => ba.Book).Include(ba => ba.Author).ToList();
			ViewBag.Currency = _db.Bios.FirstOrDefault().Currency;
			ViewBag.Total = 0;
			foreach (BookInCart bookInCart in bookInCarts)
			{

			}
			BasketVM model = new BasketVM
			{
				BookInCarts = bookInCarts
				//BookAuthors = bookAuthors
			};
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[ActionName("Index")]
		public async Task<IActionResult> Sale(BasketVM info)
		{
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			List<BookInCart> bookInCarts = _db.BookInCarts.Include(bc => bc.Book).ThenInclude(b=>b.Publisher).Include(bc => bc.AppUser).OrderBy(bc => bc.Id).Where(bc => bc.AppUserId == user.Id).ToList();
			ViewBag.Currency = _db.Bios.FirstOrDefault().Currency;
			Sale sale = new Sale();
			decimal total = 0;
			if (Request.Form["Type"].ToString().ToLower() == "metro")
			{
				sale.Date = DateTime.Now;
				sale.AppUserId = user.Id;
				sale.PhoneNumber = info.PhoneNumber;
				sale.DeliveryType = Request.Form["Type"];
				sale.DeliveryLocation = Request.Form["Metro"];
			}
			else if (Request.Form["Type"].ToString().ToLower() == "şəhər daxili")
			{
				sale.Date = DateTime.Now;
				sale.AppUserId = user.Id;
				sale.PhoneNumber = info.PhoneNumber;
				sale.DeliveryType = Request.Form["Type"];
				sale.DeliveryLocation = Request.Form["City"];
				total = 2;
			}
			else if (Request.Form["Type"].ToString().ToLower() == "rayon")
			{
				sale.Date = DateTime.Now;
				sale.AppUserId = user.Id;
				sale.PhoneNumber = info.PhoneNumber;
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

					if (bookInCart.Book.Publisher.Discount<=0)
					{
						saleBooks.Add(new SaleBook
						{
							SaleId = sale.Id,
							Count = int.Parse(Request.Form["Count"][i]),
							Price = decimal.Round((bookInCart.Book.Price * ViewBag.Currency),2),
							BookId = bookInCart.Book.Id,
							AppUserId = user.Id
						});
					}
					else
					{
						saleBooks.Add(new SaleBook
						{
							SaleId = sale.Id,
							Count = int.Parse(Request.Form["Count"][i]),
							Price = decimal.Round((bookInCart.Book.Price * ViewBag.Currency * ((decimal)(100 - bookInCart.Book.Publisher.Discount) / 100)),2),
							BookId = bookInCart.Book.Id,
							AppUserId = user.Id
						});
					}
					if (bookInCart.Book.Publisher.Discount <= 0)
					{
						total += decimal.Round((bookInCart.Book.Price * ViewBag.Currency),2) * int.Parse(Request.Form["Count"][i]);
					}
					else
					{
						total +=decimal.Round((bookInCart.Book.Price * ViewBag.Currency * ((decimal)(100 - bookInCart.Book.Publisher.Discount) / 100)),2) * int.Parse(Request.Form["Count"][i]);

					}
					Book bookCount = _db.Books.FirstOrDefault(b => b.Id == bookInCart.BookId);
					if (bookCount.Count != 0)
					{
						if (bookCount.Count > int.Parse(Request.Form["Count"][i]))
						{
							bookCount.Count -= int.Parse(Request.Form["Count"][i]);
						}
						else
						{
							bookCount.Count = 0;
						}
					}
					bookCount.SaleCount += int.Parse(Request.Form["Count"][i]);
					i++;
					_db.BookInCarts.Remove(bookInCart);
				}
			}
			sale.Total = total;
			sale.SaleBooks = saleBooks;
			await _db.Sales.AddAsync(sale);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index", "Home");

		}
		public async Task<IActionResult> DeleteBook(int? id)
		{
			if (id == null) return NotFound();
			BookInCart bookInCart = _db.BookInCarts.FirstOrDefault(bc => bc.BookId == id);
			_db.BookInCarts.Remove(bookInCart);
			await _db.SaveChangesAsync();
			return RedirectToRoute(new
			{
				controller = "Basket",
				action = "Index",
				username = User.Identity.Name
			});
		}
		[Authorize]
		public async Task<IActionResult> DeleteBooks()
		{
			List<BookInCart> booksInCart = _db.BookInCarts.Include(bc=>bc.AppUser).Where(bc => bc.AppUser.UserName.ToLower() == User.Identity.Name.ToLower()).ToList();
			foreach (BookInCart book in booksInCart)
			{
				_db.BookInCarts.Remove(book);
			}
			await _db.SaveChangesAsync();
			return RedirectToRoute(new
			{
				controller = "Basket",
				action = "Index",
				username = User.Identity.Name
			});
		}
	}
}