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
	public class NewBooksController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly UserManager<AppUser> _userManager;
		public NewBooksController(ApplicationDbContext db, UserManager<AppUser> userManager)
		{
			_db = db;
			_userManager = userManager;
		}
		public IActionResult Index(string pslug, string aslug, string cslug, int page = 1)
		{
			ViewBag.Page = page;
			ViewBag.PageCount = Math.Ceiling((decimal)_db.Books.Count() / 3);
			List<Book> books = new List<Book>();

			List<BookCategory> bookCategories = new List<BookCategory>();
			ViewBag.Aslug = "";
			ViewBag.Pslug = "";
			ViewBag.Cslug = "";
			List<Book> allBooks = new List<Book>();

			List<BookAuthor> bookAuthors = _db.BookAuthors.ToList();
			List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
			List<Publisher> publishers = _db.Publishers.OrderByDescending(n => n.BookCount).ToList();
			List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();
			if (pslug != null && aslug == null && cslug == null)
			{
				Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Slug == pslug);
				ViewBag.Pslug = publisher.Name;
				List<Book> pBooks = _db.Books.Where(b => b.PublisherId == publisher.Id).ToList();
				foreach (Book book in pBooks)
				{
					if (books.FirstOrDefault(b => b.Id == book.Id) == null)
					{
						books.Add(book);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else if (pslug == null && aslug != null && cslug == null)
			{
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.Author.Slug == aslug).ToList();
				ViewBag.Aslug = _db.BookAuthors.Include(ba => ba.Author).FirstOrDefault(ba => ba.Author.Slug == aslug).Author.Fullname;
				foreach (BookAuthor ba in aBooks)
				{
					Book newBook = _db.Books.FirstOrDefault(b => b.Id == ba.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else if (pslug == null && aslug == null && cslug != null)
			{
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				ViewBag.Cslug = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).FirstOrDefault(bc => bc.Category.Slug == cslug).Category.Name;
				foreach (BookCategory bc in bookCategories)
				{
					Book newBook = _db.Books.FirstOrDefault(b => b.Id == bc.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else if (pslug != null && aslug != null && cslug == null)
			{
				Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Slug == pslug);
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Include(ba => ba.Book).Where(ba => ba.Author.Slug == aslug).ToList();
				ViewBag.Aslug = _db.BookAuthors.Include(ba => ba.Author).Include(ba => ba.Book).FirstOrDefault(ba => ba.Author.Slug == aslug).Author.Fullname;
				ViewBag.Pslug = publisher.Name;
				List<BookAuthor> paBooks = aBooks.Where(ba => ba.Book.PublisherId == publisher.Id).ToList();
				foreach (BookAuthor ba in paBooks)
				{
					Book newBook = _db.Books.FirstOrDefault(b => b.Id == ba.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else if (pslug != null && aslug == null && cslug != null)
			{
				Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Slug == pslug);
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				List<BookCategory> pcBooks = bookCategories.Where(bc => bc.Book.PublisherId == publisher.Id).ToList();
				ViewBag.Pslug = publisher.Name;
				ViewBag.Cslug = _db.BookCategories.Include(bc => bc.Book).FirstOrDefault(bc => bc.Book.PublisherId == publisher.Id).Category.Name;
				foreach (BookCategory bc in pcBooks)
				{
					Book newBook = _db.Books.FirstOrDefault(b => b.Id == bc.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else if (pslug == null && aslug != null && cslug != null)
			{
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.Author.Slug == aslug).ToList();
				List<BookCategory> acBooks = new List<BookCategory>();
				ViewBag.Aslug = _db.BookAuthors.Include(ba => ba.Author).FirstOrDefault(ba => ba.Author.Slug == aslug).Author.Fullname;
				ViewBag.Cslug = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).FirstOrDefault(bc => bc.Category.Slug == cslug).Category.Name;
				foreach (BookAuthor abook in aBooks)
				{
					BookCategory newBc = bookCategories.FirstOrDefault(bc => bc.BookId == abook.BookId);
					acBooks.Add(newBc);
				}
				foreach (BookCategory acBook in acBooks)
				{

					if (acBook != null)
					{
						Book newBook = _db.Books.FirstOrDefault(b => b.Id == acBook.BookId);
						if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
						{
							books.Add(newBook);
						}
					}

				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else if (pslug != null && aslug != null && cslug != null)
			{
				Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Slug == pslug);
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.Author.Slug == aslug).ToList();
				List<BookCategory> acBooks = new List<BookCategory>();
				ViewBag.Aslug = _db.BookAuthors.Include(ba => ba.Author).FirstOrDefault(ba => ba.Author.Slug == aslug).Author.Fullname;
				ViewBag.Pslug = publisher.Name;
				ViewBag.Cslug = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).FirstOrDefault(bc => bc.Category.Slug == cslug).Category.Name;
				foreach (BookAuthor abook in aBooks)
				{
					BookCategory newBc = bookCategories.FirstOrDefault(bc => bc.BookId == abook.BookId);
					if (newBc != null && newBc.Book.PublisherId == publisher.Id)
					{
						acBooks.Add(newBc);
					}
				}
				foreach (BookCategory acBook in acBooks)
				{

					if (acBook != null)
					{
						Book newBook = _db.Books.FirstOrDefault(b => b.Id == acBook.BookId);
						if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
						{
							books.Add(newBook);
						}
					}

				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 3);
				allBooks = books;
				books = books.Skip((page - 1) * 3).Take(3).ToList();
			}
			else
			{
				allBooks = _db.Books.ToList();
				books = _db.Books.Skip((page - 1) * 3).Take(3).ToList();
			}
			NewBooksVM model = new NewBooksVM
			{
				Books = books,
				AllBooks = allBooks,
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
			List<BookAuthor> rBookAuthors = _db.BookAuthors.Include(ba => ba.Author).ToList();
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
				rBookAuthors = rBookAuthors
			};
			return View(model);
		}

		[Authorize]
		public async Task<IActionResult> AddCart(int? id)
		{
			if (id == null) return NotFound();
			Book book = await _db.Books.FindAsync(id);
			if (book == null) return NotFound();
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

			BookInCart bookInCart = _db.BookInCarts.FirstOrDefault(bc => bc.BookId == book.Id);
			if (bookInCart == null)
			{
				BookInCart newBook = new BookInCart
				{
					BookId = book.Id,
					AppUserId = user.Id,
					Count = 1
				};
				_db.BookInCarts.Add(newBook);
			}
			else
			{
				bookInCart.Count++;
			}
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		[Authorize]
		public async Task<IActionResult> AddFavorite(int? id)
		{
			if (id == null) return NotFound();
			Book book = await _db.Books.FindAsync(id);
			if (book == null) return NotFound();
			AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (user == null) return NotFound();
			FavoriteBook fbook = _db.FavoriteBooks.FirstOrDefault(fb => fb.AppUserId == user.Id && fb.BookId == book.Id);
			FavoriteBook favoriteBook = new FavoriteBook();
			if (fbook == null)
			{
				favoriteBook.BookId = book.Id;
				favoriteBook.AppUserId = user.Id;
				await _db.FavoriteBooks.AddAsync(favoriteBook);
				await _db.SaveChangesAsync();
			}
			return RedirectToAction("Index");
		}
	}
}