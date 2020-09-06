using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Extentions;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
	[Area("BakumozAdminPanel")]
	public class BooksController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly IHostingEnvironment _env;
		public BooksController(ApplicationDbContext db, IHostingEnvironment env)
		{
			_db = db;
			_env = env;
		}
		public IActionResult Index(int page = 1)
		{
			ViewBag.Page = page;
			ViewBag.PageCount = Math.Ceiling((decimal)_db.Books.Count() / 16);
			List<Book> books = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Skip((page - 1) * 16).Take(16).ToList();
			return View(books);
		}
		public IActionResult Detail(int? id)
		{
			if (id == null) return NotFound();
			Book book = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookFeature).FirstOrDefault(b => b.Id == id);
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
				Publishers = publishers
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
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			if (!book.Photo.IsImage())
			{
				ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			if (!book.Photo.MaxLength(1024))
			{
				ModelState.AddModelError("", "Faylın ölçüsü 1 MB-dan az olmalıdır");
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			Book newBook = new Book
			{
				Name = book.Name,
				Slug=book.Slug,
				Description = book.Description,
				Price = book.Price,
				Count = book.Count
			};
			Book existBook = _db.Books.FirstOrDefault(b => b.Name.ToLower().Trim() == book.Name.ToLower().Trim());
			if (existBook != null)
			{
				ModelState.AddModelError("", "Bu kitab mövcuddur");
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			newBook.ImagePath = await book.Photo.SaveImg(_env.WebRootPath, "image");
			string authorsList = Request.Form["authors"];
			if (authorsList == null)
			{
				ModelState.AddModelError("", "Zəhmət olmasa yazar seçin");
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			List<BookAuthor> bookAuthors = new List<BookAuthor>();
			string[] authorArr = authorsList.Split(",");
			List<int> authorIds = new List<int>();
			foreach (string authorId in authorArr)
			{

				authorIds.Add(int.Parse(authorId));
			}

			foreach (int id in authorIds)
			{
				bookAuthors.Add(new BookAuthor
				{
					BookId = newBook.Id,
					AuthorId = id
				});
			}

			string categoryList = Request.Form["categories"];
			if (categoryList == null)
			{
				ModelState.AddModelError("", "Zəhmət olmasa kateqoriya seçin");
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			List<BookCategory> bookCategories = new List<BookCategory>();
			string[] categoryArr = categoryList.Split(",");
			List<int> categoryIds = new List<int>();
			foreach (string categoryId in categoryArr)
			{

				categoryIds.Add(int.Parse(categoryId));
			}

			foreach (int id in categoryIds)
			{
				bookCategories.Add(new BookCategory
				{
					BookId = newBook.Id,
					CategoryId = id
				});
			}
			BookFeature bookFeature = new BookFeature
			{
				PublishingPlace=book.PublishingPlace,
				PublishingDate = book.PublishingDate,
				PublishingLanguage = book.PublishingLanguage,
				OriginalLanguage = book.OriginalLanguage,
				Translator = book.Translator
			};
			string publisherId = Request.Form["publishers"];
			Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Id == int.Parse(publisherId));
			if (publisher == null)
			{
				ModelState.AddModelError("", "Zəhmət olmasa yayın evi seçin");
				List<Author> authors = _db.Authors.ToList();
				List<Category> categories = _db.Categories.ToList();
				List<Publisher> publishers = _db.Publishers.ToList();
				BookVM model = new BookVM
				{
					Authors = authors,
					Categories = categories,
					Publishers = publishers
				};
				return View(model);
			}
			publisher.BookCount++;
			newBook.PublisherId = publisher.Id;
			newBook.BookAuthors = bookAuthors;
			newBook.BookCategories = bookCategories;
			newBook.BookFeature = bookFeature;
			_db.Books.Add(newBook);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		public IActionResult Edit(int? id)
		{
			if (id == null) return NotFound();
			Book book = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookFeature).FirstOrDefault(b => b.Id == id);
			if (book == null) return NotFound();
			List<Author> authors = _db.Authors.ToList();
			List<Category> categories = _db.Categories.ToList();
			List<Publisher> publishers = _db.Publishers.ToList();
			BookVM model = new BookVM
			{
				Book = book,
				Authors = authors,
				Categories = categories,
				Publishers = publishers
			};
			return View(model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int? id, BookVM editedBook)
		{
			if (id == null) return NotFound();
			Book book = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookFeature).FirstOrDefault(b => b.Id == id);
			if (book == null) return NotFound();
			if (editedBook.Photo == null)
			{
				Book existBook = _db.Books.FirstOrDefault(b => b.Name.ToLower().Trim() == editedBook.Book.Name.ToLower().Trim());
				if (existBook != null)
				{
					if (book.Name.ToLower().Trim() != existBook.Name.ToLower().Trim())
					{
						ModelState.AddModelError("", "Bu kitab mövcuddur");
						List<Author> authors = _db.Authors.ToList();
						List<Category> categories = _db.Categories.ToList();
						List<Publisher> publishers = _db.Publishers.ToList();
						BookVM model = new BookVM
						{
							Book = book,
							Authors = authors,
							Categories = categories,
							Publishers = publishers
						};
						return View(model);
					}
				}
				book.Name = editedBook.Book.Name;
				book.Slug = editedBook.Book.Slug;
				book.Count = editedBook.Book.Count;
				book.Price = editedBook.Book.Price;
				book.Description = editedBook.Book.Description;
				string authorsList = Request.Form["authors"];
				if (authorsList == null)
				{
					ModelState.AddModelError("", "Zəhmət olmasa yazar seçin");
					List<Author> authors = _db.Authors.ToList();
					List<Category> categories = _db.Categories.ToList();
					List<Publisher> publishers = _db.Publishers.ToList();
					BookVM model = new BookVM
					{
						Book = book,
						Authors = authors,
						Categories = categories,
						Publishers = publishers
					};
					return View(model);
				}
				List<BookAuthor> bookAuthors = new List<BookAuthor>();
				string[] authorArr = authorsList.Split(",");
				List<int> authorIds = new List<int>();
				foreach (string authorId in authorArr)
				{

					authorIds.Add(int.Parse(authorId));
				}

				foreach (int authorId in authorIds)
				{
					bookAuthors.Add(new BookAuthor
					{
						BookId = book.Id,
						AuthorId = authorId
					});
				}

				string categoryList = Request.Form["categories"];
				if (categoryList == null)
				{
					ModelState.AddModelError("", "Zəhmət olmasa kateqoriya seçin");
					List<Author> authors = _db.Authors.ToList();
					List<Category> categories = _db.Categories.ToList();
					List<Publisher> publishers = _db.Publishers.ToList();
					BookVM model = new BookVM
					{
						Book = book,
						Authors = authors,
						Categories = categories,
						Publishers = publishers
					};
					return View(model);
				}
				List<BookCategory> bookCategories = new List<BookCategory>();
				string[] categoryArr = categoryList.Split(",");
				List<int> categoryIds = new List<int>();
				foreach (string categoryId in categoryArr)
				{

					categoryIds.Add(int.Parse(categoryId));
				}

				foreach (int categoryId in categoryIds)
				{
					bookCategories.Add(new BookCategory
					{
						BookId = book.Id,
						CategoryId = categoryId
					});
				}
				BookFeature bookFeature = new BookFeature
				{
					PublishingPlace=editedBook.Book.BookFeature.PublishingPlace,
					PublishingDate = editedBook.Book.BookFeature.PublishingDate,
					PublishingLanguage = editedBook.Book.BookFeature.PublishingLanguage,
					OriginalLanguage = editedBook.Book.BookFeature.OriginalLanguage,
					Translator = editedBook.Book.BookFeature.Translator
				};
				Publisher oldPublisher = new Publisher();
				Publisher newPublisher = new Publisher();
				string publisherId = Request.Form["publishers"];
				if (book.PublisherId != int.Parse(publisherId))
				{
					oldPublisher = _db.Publishers.FirstOrDefault(p => p.Id == book.PublisherId);
					oldPublisher.BookCount--;
					newPublisher = _db.Publishers.FirstOrDefault(p => p.Id == int.Parse(publisherId));
					newPublisher.BookCount++;
					book.PublisherId = newPublisher.Id;
				}
				book.BookAuthors = bookAuthors;
				book.BookCategories = bookCategories;
				book.BookFeature = bookFeature;
				await _db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			else
			{
				if (!editedBook.Photo.IsImage())
				{
					ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
					List<Author> authors = _db.Authors.ToList();
					List<Category> categories = _db.Categories.ToList();
					List<Publisher> publishers = _db.Publishers.ToList();
					BookVM model = new BookVM
					{
						Book = book,
						Authors = authors,
						Categories = categories,
						Publishers = publishers
					};
					return View(model);
				}
				if (!editedBook.Photo.MaxLength(1024))
				{
					ModelState.AddModelError("", "Faylın ölçüsü 1 MB-dan az olmalıdır");
					List<Author> authors = _db.Authors.ToList();
					List<Category> categories = _db.Categories.ToList();
					List<Publisher> publishers = _db.Publishers.ToList();
					BookVM model = new BookVM
					{
						Book = book,
						Authors = authors,
						Categories = categories,
						Publishers = publishers
					};
					return View(model);
				}
				Book existBook = _db.Books.FirstOrDefault(b => b.Name.ToLower().Trim() == editedBook.Book.Name.ToLower().Trim());
				if (existBook != null)
				{
					if (book.Name.ToLower().Trim() != existBook.Name.ToLower().Trim())
					{
						ModelState.AddModelError("", "Bu kitab mövcuddur");
						List<Author> authors = _db.Authors.ToList();
						List<Category> categories = _db.Categories.ToList();
						List<Publisher> publishers = _db.Publishers.ToList();
						BookVM model = new BookVM
						{
							Book = book,
							Authors = authors,
							Categories = categories,
							Publishers = publishers
						};
						return View(model);
					}
				}
				Helpers.Helper.DeleteImg(_env.WebRootPath,"image",book.ImagePath);
				book.ImagePath = await editedBook.Photo.SaveImg(_env.WebRootPath,"image");
				book.Name = editedBook.Book.Name;
				book.Slug = editedBook.Book.Slug;
				book.Count = editedBook.Book.Count;
				book.Price = editedBook.Book.Price;
				book.Description = editedBook.Book.Description;
				string authorsList = Request.Form["authors"];
				if (authorsList == null)
				{
					ModelState.AddModelError("", "Zəhmət olmasa yazar seçin");
					List<Author> authors = _db.Authors.ToList();
					List<Category> categories = _db.Categories.ToList();
					List<Publisher> publishers = _db.Publishers.ToList();
					BookVM model = new BookVM
					{
						Book = book,
						Authors = authors,
						Categories = categories,
						Publishers = publishers
					};
					return View(model);
				}
				List<BookAuthor> bookAuthors = new List<BookAuthor>();
				string[] authorArr = authorsList.Split(",");
				List<int> authorIds = new List<int>();
				foreach (string authorId in authorArr)
				{

					authorIds.Add(int.Parse(authorId));
				}

				foreach (int authorId in authorIds)
				{
					bookAuthors.Add(new BookAuthor
					{
						BookId = book.Id,
						AuthorId = authorId
					});
				}

				string categoryList = Request.Form["categories"];
				if (categoryList == null)
				{
					ModelState.AddModelError("", "Zəhmət olmasa kateqoriya seçin");
					List<Author> authors = _db.Authors.ToList();
					List<Category> categories = _db.Categories.ToList();
					List<Publisher> publishers = _db.Publishers.ToList();
					BookVM model = new BookVM
					{
						Book = book,
						Authors = authors,
						Categories = categories,
						Publishers = publishers
					};
					return View(model);
				}
				List<BookCategory> bookCategories = new List<BookCategory>();
				string[] categoryArr = categoryList.Split(",");
				List<int> categoryIds = new List<int>();
				foreach (string categoryId in categoryArr)
				{

					categoryIds.Add(int.Parse(categoryId));
				}

				foreach (int categoryId in categoryIds)
				{
					bookCategories.Add(new BookCategory
					{
						BookId = book.Id,
						CategoryId = categoryId
					});
				}
				BookFeature bookFeature = new BookFeature
				{
					PublishingPlace=editedBook.Book.BookFeature.PublishingPlace,
					PublishingDate = editedBook.Book.BookFeature.PublishingDate,
					PublishingLanguage = editedBook.Book.BookFeature.PublishingLanguage,
					OriginalLanguage = editedBook.Book.BookFeature.OriginalLanguage,
					Translator = editedBook.Book.BookFeature.Translator
				};
				Publisher oldPublisher = new Publisher();
				Publisher newPublisher = new Publisher();
				string publisherId = Request.Form["publishers"];
				if (book.PublisherId != int.Parse(publisherId))
				{
					oldPublisher = _db.Publishers.FirstOrDefault(p => p.Id == book.PublisherId);
					oldPublisher.BookCount--;
					newPublisher = _db.Publishers.FirstOrDefault(p => p.Id == int.Parse(publisherId));
					newPublisher.BookCount++;
					book.PublisherId = newPublisher.Id;
				}
				book.BookAuthors = bookAuthors;
				book.BookCategories = bookCategories;
				book.BookFeature = bookFeature;
				await _db.SaveChangesAsync();
				return RedirectToAction("Index");
			}
		}
		public IActionResult Delete(int? id)
		{
			if (id == null) return NotFound();
			Book book = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookFeature).FirstOrDefault(b => b.Id == id);
			if (book == null) return NotFound();
			return View(book);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ActionName("Delete")]
		public async Task<IActionResult> DeletePost(int? id)
		{
			if (id == null) return NotFound();
			Book book = _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).Include(b => b.Publisher).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookFeature).FirstOrDefault(b => b.Id == id);
			if (book == null) return NotFound();
			Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Id == book.PublisherId);
			publisher.BookCount--;
			_db.Books.Remove(book);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}