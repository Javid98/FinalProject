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
		public async Task<IActionResult> Index(string pslug, string aslug, string cslug, int page = 1)
		{
			ViewBag.Page = page;
			ViewBag.PageCount = Math.Ceiling((decimal)_db.Books.Count() / 10);
			List<Book> books = new List<Book>();
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

			List<BookCategory> bookCategories = new List<BookCategory>();
			ViewBag.Aslug = "";
			ViewBag.Pslug = "";
			ViewBag.Cslug = "";
			List<Book> allBooks = new List<Book>();

			List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
			List<Publisher> publishers = _db.Publishers.OrderByDescending(n => n.BookCount).ToList();
			List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();
			if (pslug != null && aslug == null && cslug == null)
			{
				Publisher publisher = publishers.FirstOrDefault(p => p.Slug == pslug);
				if (publisher != null)
				{
					ViewBag.Pslug = publisher.Name;
				}
				List<Book> pBooks = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Where(b => b.PublisherId == publisher.Id).ToList();
				foreach (Book book in pBooks)
				{
					if (books.FirstOrDefault(b => b.Id == book.Id) == null)
					{
						books.Add(book);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else if (pslug == null && aslug != null && cslug == null)
			{
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.Author.Slug == aslug).ToList();
				if (authors.FirstOrDefault(a => a.Slug == aslug) != null)
				{
					ViewBag.Aslug = authors.FirstOrDefault(a => a.Slug == aslug).Fullname;
				}
				foreach (BookAuthor ba in aBooks)
				{
					Book newBook = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(b => b.Author).FirstOrDefault(b => b.Id == ba.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else if (pslug == null && aslug == null && cslug != null)
			{
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				if (categories.FirstOrDefault(c => c.Slug == cslug) != null)
				{
					ViewBag.Cslug = categories.FirstOrDefault(c => c.Slug == cslug).Name;
				}
				foreach (BookCategory bc in bookCategories)
				{
					Book newBook = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefault(b => b.Id == bc.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else if (pslug != null && aslug != null && cslug == null)
			{
				Publisher publisher = publishers.FirstOrDefault(p => p.Slug == pslug);
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Include(ba => ba.Book).Where(ba => ba.Author.Slug == aslug).ToList();
				if (authors.FirstOrDefault(a => a.Slug == aslug) != null && publisher != null)
				{
					ViewBag.Aslug = authors.FirstOrDefault(a => a.Slug == aslug).Fullname;
					ViewBag.Pslug = publisher.Name;
				}
				List<BookAuthor> paBooks = aBooks.Where(ba => ba.Book.PublisherId == publisher.Id).ToList();
				foreach (BookAuthor ba in paBooks)
				{
					Book newBook = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(b => b.Author).FirstOrDefault(b => b.Id == ba.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else if (pslug != null && aslug == null && cslug != null)
			{
				Publisher publisher = publishers.FirstOrDefault(p => p.Slug == pslug);
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				List<BookCategory> pcBooks = bookCategories.Where(bc => bc.Book.PublisherId == publisher.Id).ToList();
				if (categories.FirstOrDefault(c => c.Slug == cslug) != null && publisher != null)
				{
					ViewBag.Pslug = publisher.Name;
					ViewBag.Cslug = categories.FirstOrDefault(c => c.Slug == cslug).Name;
				}
				foreach (BookCategory bc in pcBooks)
				{
					Book newBook = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefault(b => b.Id == bc.BookId);
					if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
					{
						books.Add(newBook);
					}
				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else if (pslug == null && aslug != null && cslug != null)
			{
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.Author.Slug == aslug).ToList();
				List<BookCategory> acBooks = new List<BookCategory>();
				if (authors.FirstOrDefault(a => a.Slug == aslug) != null && categories.FirstOrDefault(c => c.Slug == cslug) != null)
				{
					ViewBag.Aslug = authors.FirstOrDefault(a => a.Slug == aslug).Fullname;
					ViewBag.Cslug = categories.FirstOrDefault(c => c.Slug == cslug).Name;
				}
				foreach (BookAuthor abook in aBooks)
				{
					BookCategory newBc = bookCategories.FirstOrDefault(bc => bc.BookId == abook.BookId);
					acBooks.Add(newBc);
				}
				foreach (BookCategory acBook in acBooks)
				{

					if (acBook != null)
					{
						Book newBook = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefault(b => b.Id == acBook.BookId);
						if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
						{
							books.Add(newBook);
						}
					}

				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else if (pslug != null && aslug != null && cslug != null)
			{
				Publisher publisher = publishers.FirstOrDefault(p => p.Slug == pslug);
				bookCategories = _db.BookCategories.Include(bc => bc.Category).Include(bc => bc.Book).Where(bc => bc.Category.Slug == cslug).ToList();
				List<BookAuthor> aBooks = _db.BookAuthors.Include(ba => ba.Author).Where(ba => ba.Author.Slug == aslug).ToList();
				List<BookCategory> acBooks = new List<BookCategory>();
				if (authors.FirstOrDefault(a => a.Slug == aslug) != null && publisher != null && categories.FirstOrDefault(c => c.Slug == cslug) != null)
				{
					ViewBag.Aslug = authors.FirstOrDefault(a => a.Slug == aslug).Fullname;
					ViewBag.Pslug = publisher.Name;
					ViewBag.Cslug = categories.FirstOrDefault(c => c.Slug == cslug).Name;
				}
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
						Book newBook = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefault(b => b.Id == acBook.BookId);
						if (books.FirstOrDefault(b => b.Id == newBook.Id) == null)
						{
							books.Add(newBook);
						}
					}

				}
				ViewBag.PageCount = Math.Ceiling((decimal)books.Count() / 10);
				allBooks = books;
				books = books.Skip((page - 1) * 10).Take(10).ToList();
			}
			else
			{
				allBooks = _db.Books.Include(b => b.Publisher).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).ToList();
				books = allBooks.Skip((page - 1) * 10).Take(10).ToList();
			}
			NewBooksVM model = new NewBooksVM
			{
				Books = books,
				AllBooks = allBooks,
				//BookAuthors = bookAuthors,
				Authors = authors,
				Publishers = publishers,
				Categories = categories,
				BookInCarts = bookInCarts,
				FavoriteBooks = favoriteBooks
			};
			return View(model);
		}

		[Route("kitab/{slug}")]
		public async Task<IActionResult> Detail(string slug)
		{
			if (slug == null) return NotFound();
			Book book = _db.Books.Include(b => b.Publisher).Include(b => b.BookFeature).Include(b => b.BookCategories).ThenInclude(b => b.Category).Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefault(b => b.Slug == slug);
			if (book == null) return NotFound();
			List<BookAuthor> rBookAuthors = _db.BookAuthors.Include(ba => ba.Author).ToList();
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

			List<BookCategory> rBookCategories = new List<BookCategory>();

			foreach (BookCategory bookCategory in book.BookCategories)
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
				rBookCategories = rBookCategories,
				rBookAuthors = rBookAuthors,
				BookInCarts = bookInCarts,
				FavoriteBooks = favoriteBooks
			};
			return View(model);
		}

		[Authorize]
		public async Task<IActionResult> AddCart(int? id, string actionName, string queryString)
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
			if (actionName.Contains("/kitab/"))
			{
				return RedirectToRoute(new
				{
					controller = "kitab",
					action = book.Slug
				});
			}
			else if (actionName.Contains("BestSellers"))
			{
				return Redirect("/BestSellers/Index" + queryString);
			}
			else
			{
				return Redirect("/NewBooks/Index" + queryString);
			}
		}

		[Authorize]
		public async Task<IActionResult> AddFavorite(int? id, string actionName, string queryString)
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
			if (actionName.Contains("/kitab/"))
			{
				return RedirectToRoute(new
				{
					controller = "kitab",
					action = book.Slug
				});
			}
			else if (actionName.Contains("BestSellers"))
			{
				return Redirect("/BestSellers/Index" + queryString);
			}
			else
			{
				return Redirect("/NewBooks/Index" + queryString);
			}
		}
	}
}