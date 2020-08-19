using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class BestSellersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BestSellersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Book> bestSellers = _db.Books.OrderByDescending(b => b.SaleCount).Take(100).ToList();
            List<BookAuthor> bookAuthors = _db.BookAuthors.ToList();
            List<Author> authors = _db.Authors.OrderBy(n => n.Fullname).ToList();
            List<Publisher> publishers = _db.Publishers.OrderByDescending(n => n.BookCount).ToList();
            List<Category> categories = _db.Categories.OrderBy(n => n.Name).ToList();
            NewBooksVM model = new NewBooksVM
            {
                Books = bestSellers,
                BookAuthors = bookAuthors,
                Authors = authors,
                Publishers = publishers,
                Categories = categories
            };
            return View(model);
        }
    }
}