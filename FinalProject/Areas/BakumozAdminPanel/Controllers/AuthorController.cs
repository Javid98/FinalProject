using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
    [Area("BakumozAdminPanel")]
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AuthorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Authors.Count() / 20);
            List<Author> authors = _db.Authors.Skip((page - 1) * 20).Take(20).ToList();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author)
        {
            if (author.Slug == null) return View();
            Author existAuthor = _db.Authors.FirstOrDefault(c => c.Fullname.ToLower().Trim() == author.Fullname.ToLower().Trim());
            if (existAuthor != null)
            {
                ModelState.AddModelError("", "Bu yazar mövcuddur");
                return View();
            }
            Author newAuthor = new Author
            {
                Fullname = author.Fullname,
                Slug = author.Slug
            };
            _db.Authors.Add(newAuthor);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Author author = _db.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Author editedAuthor)
        {
            if (id == null) return NotFound();
            Author author = _db.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            Author existAuthor = _db.Authors.FirstOrDefault(c => c.Fullname.ToLower().Trim() == editedAuthor.Fullname.ToLower().Trim());
            if (existAuthor != null)
            {
                if(author.Fullname.ToLower().Trim() != existAuthor.Fullname.ToLower().Trim())
                {
                    ModelState.AddModelError("", "Bu yazar mövcuddur");
                    return View();
                }
            }
            if (editedAuthor.Slug == null) return View();
            author.Fullname = editedAuthor.Fullname;
            author.Slug = editedAuthor.Slug;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Author author = _db.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAuthor(int? id)
        {
            if (id == null) return NotFound();
            Author author = _db.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            _db.Authors.Remove(author);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}