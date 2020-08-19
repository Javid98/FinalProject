using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.ViewModels;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _db;
		public HomeController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<Book> books = _db.Books.ToList();
			Book book = _db.Books.OrderByDescending(b => b.SaleCount).FirstOrDefault();
			List<BookCategory> bookCategories = _db.BookCategories.Include(ba => ba.Category).Where(bc => bc.BookId == book.Id).ToList();
			List<BookAuthor> bookAuthors = _db.BookAuthors.ToList();
			List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
			List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();

			List<BookCategory> rBookCategories = new List<BookCategory>();

			foreach (BookCategory bookCategory in bookCategories)
			{
				List<BookCategory> NewrBookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).OrderByDescending(nrbc => nrbc.Id).Where(bc => bc.CategoryId == bookCategory.CategoryId).ToList();
				foreach (BookCategory newR in NewrBookCategories)
				{
					if (rBookCategories.FirstOrDefault(bc => bc.BookId == newR.BookId) == null && newR.BookId != book.Id)
					{
						rBookCategories.Add(newR);
					}
				}
			}
			NewBooksVM model = new NewBooksVM
			{
				Books = books,
				Book = book,
				BookAuthors = bookAuthors,
				Authors = authors,
				Categories = categories,
				rBookCategories = rBookCategories
			};
			return View(model);
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
