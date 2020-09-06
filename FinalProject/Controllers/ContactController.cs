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
    public class ContactController : Controller
    {
        public readonly ApplicationDbContext _db;
        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            Bio bio = _db.Bios.FirstOrDefault();
            if (bio == null) return NotFound();
            ContactVM model = new ContactVM
            {
                Bio = bio
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> SendMessage(Contact contact)
        {
            Contact newContact = new Contact
            {
                Name = contact.Name,
                Surname = contact.Surname,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber,
                Message = contact.Message,
                Date=DateTime.Now
            };
            _db.Contacts.Add(newContact);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index","Home");
        }
    }
}