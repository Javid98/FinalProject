using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Extentions;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
    [Area("BakumozAdminPanel")]
    public class BioController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _env;
        public BioController(ApplicationDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            Bio bio = _db.Bios.FirstOrDefault();
            if (bio == null) return NotFound();
            return View(bio);
        }
        public IActionResult Edit()
        {
            Bio bio = _db.Bios.FirstOrDefault();
            if (bio == null) return NotFound();
            return View(bio);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Bio editedBio)
        {
            Bio bio = _db.Bios.FirstOrDefault();
            if (bio == null) return NotFound();
            if (editedBio.Photo == null)
            {
                bio.PhoneNumber = editedBio.PhoneNumber;
                bio.FacebookLink = editedBio.FacebookLink;
                bio.InstagramLink = editedBio.InstagramLink;
                bio.Gmail = editedBio.Gmail;
                bio.Country = editedBio.Country;
                bio.City = editedBio.City;
                bio.Street = editedBio.Street;
                string currency = Request.Form["Currency"];
                currency = currency.Replace('.', ',');
                bio.Currency = Convert.ToDecimal(currency);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                if (!editedBio.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin");
                    return View(bio);
                }
                if (!editedBio.Photo.MaxLength(1024))
                {
                    ModelState.AddModelError("", "Şəkilin ölçüsü maksimum 1 MB ola bilər");
                    return View(bio);
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "image", bio.Logo);
                bio.Logo = await editedBio.Photo.SaveImg(_env.WebRootPath,"image");
                bio.PhoneNumber = editedBio.PhoneNumber;
                bio.FacebookLink = editedBio.FacebookLink;
                bio.InstagramLink = editedBio.InstagramLink;
                bio.Gmail = editedBio.Gmail;
                bio.Country = editedBio.Country;
                bio.City = editedBio.City;
                bio.Street = editedBio.Street;
                string currency = Request.Form["Currency"];
                currency = currency.Replace('.', ',');
                bio.Currency = Convert.ToDecimal(currency);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}