using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
	[Area("BakumozAdminPanel")]
	public class BooksController : Controller
	{
		private readonly ApplicationDbContext _db;
		public BooksController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index(int page = 1)
		{
			ViewBag.Page = page;
			ViewBag.PageCount = Math.Ceiling((decimal)_db.Books.Count() / 16);
			List<Book> books = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba=>ba.Author).Skip((page - 1) * 16).Take(16).ToList();
			return View(books);
		}
		public IActionResult Detail(int? id)
		{
			if (id == null) return NotFound();
			Book book = _db.Books.Include(b=>b.BookAuthors).ThenInclude(ba=>ba.Author).Include(b=>b.Publisher).Include(b=>b.BookCategories).ThenInclude(bc=>bc.Category).Include(b=>b.BookFeature).FirstOrDefault(b=>b.Id==id);
			if (book == null) return NotFound();
			return View(book);
		}
		public IActionResult Create()
		{
			List<Author> authors = _db.Authors.ToList();
			List<Category> categories = _db.Categories.ToList();
			List<Publisher> publishers = _db.Publishers.ToList();
			BookVM model = new BookVM
			{
				Authors = authors,
				Categories = categories,
				Publishers=publishers
			};
			return View(model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(BookVM book)
		{
			if (book.Photo == null)
			{
				ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
				return View(book);
			}
			Book newBook = new Book
			{
				Name = book.Name,
				Description = book.Description,
				Price = book.Price,
				Count = book.Count
			};
			return Content("ok");
		}
	}
}