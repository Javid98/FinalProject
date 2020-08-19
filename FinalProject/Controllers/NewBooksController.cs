using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
	public class NewBooksController : Controller
	{
		private readonly ApplicationDbContext _db;
		public NewBooksController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<Book> books = _db.Books.ToList();
			List<BookAuthor> bookAuthors = _db.BookAuthors.ToList();
			List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
			List<Publisher> publishers = _db.Publishers.OrderByDescending(n => n.BookCount).ToList();
			List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();
			NewBooksVM model = new NewBooksVM
			{
				Books = books,
				BookAuthors = bookAuthors,
				Authors = authors,
				Publishers = publishers,
				Categories = categories
			};
			return View(model);
		}

		[Route("kitab/{slug}")]
		public IActionResult Detail(string slug)
		{
			if (slug == null) return NotFound();
			Book book = _db.Books.FirstOrDefault(b => b.Slug == slug);
			if (book == null) return NotFound();
			List<BookCategory> bookCategories = _db.BookCategories.Include(ba => ba.Category).Where(bc => bc.BookId == book.Id).ToList();
			List<BookAuthor> rBookAuthors = _db.BookAuthors.Include(ba=>ba.Author).ToList();
			List<BookAuthor> bookAuthors = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.BookId == book.Id).ToList();
			Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Id == book.PublisherId);
			BookFeature bookFeature = _db.BookFeatures.FirstOrDefault(bf => bf.BookId == book.Id);

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
				Book = book,
				BookCategories = bookCategories,
				BookAuthors = bookAuthors,
				Publisher = publisher,
				BookFeature = bookFeature,
				rBookCategories = rBookCategories,
				rBookAuthors=rBookAuthors
			};
			return View(model);
		}
	}
}