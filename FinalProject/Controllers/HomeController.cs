using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.ViewModels;
using FinalProject.Data;

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
			List<BookAuthor> bookAuthors = _db.BookAuthors.ToList();
			List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
			List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();
			NewBooksVM model = new NewBooksVM
			{
				Books = books,
				Book = book,
				BookAuthors = bookAuthors,
				Authors = authors,
				Categories = categories
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
