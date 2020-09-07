using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
	[Area("BakumozAdminPanel")]
    [Authorize(Roles ="Admin")]
    public class PublishersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PublishersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Publishers.Count() / 20);
            List<Publisher> publishers = _db.Publishers.OrderByDescending(p=>p.BookCount).Skip((page - 1) * 20).Take(20).ToList();
            return View(publishers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Publisher publisher)
        {
            if (publisher.Slug == null) return View();
            Publisher existPublisher = _db.Publishers.FirstOrDefault(c => c.Name.ToLower() == publisher.Name.ToLower());
            if (existPublisher != null)
            {
                ModelState.AddModelError("", "Bu yayın evi mövcuddur");
                return View();
            }
            Publisher newPublisher = new Publisher
            {
                Name = publisher.Name,
                BookCount=0,
                Discount=publisher.Discount,
                Slug = publisher.Slug
            };
            _db.Publishers.Add(newPublisher);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Id == id);
            if (publisher == null) return NotFound();
            return View(publisher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Publisher editedPublisher)
        {
            if (id == null) return NotFound();
            Publisher publisher = _db.Publishers.FirstOrDefault(a => a.Id == id);
            if (publisher == null) return NotFound();
            Publisher existPublisher = _db.Publishers.FirstOrDefault(p => p.Name.ToLower().Trim() == editedPublisher.Name.ToLower().Trim());
            if (existPublisher != null)
            {
                if (publisher.Name.ToLower().Trim() != existPublisher.Name.ToLower().Trim())
                {
                    ModelState.AddModelError("", "Bu yayın evi mövcuddur");
                    return View();
                }
            }
            if (editedPublisher.Slug == null) return View();
            publisher.Name = editedPublisher.Name;
            publisher.Slug = editedPublisher.Slug;
            publisher.Discount = editedPublisher.Discount;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Id == id);
            if (publisher == null) return NotFound();
            return View(publisher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePublisher(int? id)
        {
            if (id == null) return NotFound();
            Publisher publisher = _db.Publishers.FirstOrDefault(p => p.Id == id);
            if (publisher == null) return NotFound();
            _db.Publishers.Remove(publisher);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
            public IActionResult Search(string search)
		{
			List<Publisher> publishers = _db.Publishers.Where(b => b.Name.Contains(search)).ToList();

			return PartialView("_AdminPublishersSearchPartialView", publishers);
		}
    }
}