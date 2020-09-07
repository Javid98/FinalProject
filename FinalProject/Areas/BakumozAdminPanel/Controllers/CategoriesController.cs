using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Extentions;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
    [Area("BakumozAdminPanel")]
    [Authorize(Roles ="Admin")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _env;
        public CategoriesController(ApplicationDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (category.Slug == null) return View();
            if(category.Photo == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
                return View();
            }
            Category existCategory = _db.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());
            if (existCategory != null)
            {
                ModelState.AddModelError("", "Bu adda kateqoriya mövcuddur");
                return View();
            }
            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
                return View();
            }
            if (!category.Photo.MaxLength(1024))
            {
                ModelState.AddModelError("", "Faylın ölçüsü 1 MB-dan az olmalıdır");
                return View();
            }
            Category newCategory = new Category
            {
                Name = category.Name,
                Slug = category.Slug
            };
            newCategory.ImagePath = await category.Photo.SaveImg(_env.WebRootPath, "image");
            _db.Categories.Add(newCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Category category = _db.Categories.FirstOrDefault(a => a.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Category editedCategory)
        {
            if(editedCategory.Photo == null)
            {
                if (id == null) return NotFound();
                Category category = _db.Categories.FirstOrDefault(a => a.Id == id);
                if (category == null) return NotFound();
                Category existCategory = _db.Categories.FirstOrDefault(c => c.Name.ToLower().Trim() == editedCategory.Name.ToLower().Trim());
                if (existCategory != null)
                {
                    if (category.Name.ToLower().Trim() != existCategory.Name.ToLower().Trim())
                    {
                        ModelState.AddModelError("", "Bu kateqoriya mövcuddur");
                        return View();
                    }
                }
                if (editedCategory.Slug == null) return View();

                category.Name = editedCategory.Name;
                category.Slug = editedCategory.Slug;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                if (id == null) return NotFound();
                Category category = _db.Categories.FirstOrDefault(a => a.Id == id);
                if (category == null) return NotFound();
                Category existCategory = _db.Categories.FirstOrDefault(c => c.Name.ToLower().Trim() == editedCategory.Name.ToLower().Trim());
                if (existCategory != null)
                {
                    if (category.Name.ToLower() != existCategory.Name.ToLower())
                    {
                        ModelState.AddModelError("", "Bu kateqoriya mövcuddur");
                        return View();
                    }
                }
                if (editedCategory.Slug == null) return View();

                if (!editedCategory.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
                    return View();
                }
                if (!editedCategory.Photo.MaxLength(1024))
                {
                    ModelState.AddModelError("", "Faylın ölçüsü 1 MB-dan az olmalıdır");
                    return View();
                }

                Helpers.Helper.DeleteImg(_env.WebRootPath, "image", category.ImagePath);
                category.ImagePath = await editedCategory.Photo.SaveImg(_env.WebRootPath, "image");
                category.Name = editedCategory.Name;
                category.Slug = editedCategory.Slug;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = _db.Categories.FirstOrDefault(a => a.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            Category category = _db.Categories.FirstOrDefault(a => a.Id == id);
            if (category == null) return NotFound();
            Helpers.Helper.DeleteImg(_env.WebRootPath, "image", category.ImagePath);
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}