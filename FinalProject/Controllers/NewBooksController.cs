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
            List<Author> authors = _db.Authors.ToList();
            List<Publisher> publishers = _db.Publishers.ToList();
            NewBooksVM model = new NewBooksVM
            {
                Books = books,
                BookAuthors = bookAuthors,
                Authors=authors,
                Publishers = publishers
            };
            return View(model);
        }
    }
}