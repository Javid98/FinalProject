using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.BakumozAdminPanel.Controllers
{
	[Area("BakumozAdminPanel")]
	public class MessagesController : Controller
	{
		private readonly ApplicationDbContext _db;
		public MessagesController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<Contact> contacts = _db.Contacts.Where(c => c.Read == false).OrderByDescending(c=>c.Date).ToList();
			return View(contacts);
		}
		public async Task<IActionResult> Detail(int? id)
		{
			if (id == null) return NotFound();
			Contact contact = _db.Contacts.Find(id);
			if (contact == null) return NotFound();
			if (contact.Read == false)
			{
				contact.Read = true;
			}
			await _db.SaveChangesAsync();
			return View(contact);
		}
		public IActionResult AllMessages()
		{
			List<Contact> contacts = _db.Contacts.OrderByDescending(c => c.Date).ToList();
			return View(contacts);
		}
		public async Task<IActionResult> MarkAsRead(int? id)
		{
			if (id == null) return NotFound();
			Contact contact = _db.Contacts.Find(id);
			if (contact == null) return NotFound();
			contact.Read = true;
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> MarkAllMessagesAsRead()
		{
			List<Contact> contacts = _db.Contacts.Where(c => c.Read == false).ToList();
			foreach (Contact contact in contacts)
			{
				contact.Read = true;

			}
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null) return NotFound();
			Contact contact = _db.Contacts.Find(id);
			if (contact == null) return NotFound();
			_db.Contacts.Remove(contact);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> DeleteAllMessages()
		{
			List<Contact> contacts = _db.Contacts.ToList();
			foreach (Contact contact in contacts)
			{
				_db.Contacts.Remove(contact);
			}
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

	}
}