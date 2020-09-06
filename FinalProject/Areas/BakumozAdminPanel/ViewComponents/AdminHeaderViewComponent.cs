using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.BakumozAdminPanel.ViewComponents
{
	public class AdminHeaderViewComponent:ViewComponent
	{
		private readonly ApplicationDbContext _db;
		public AdminHeaderViewComponent(ApplicationDbContext db)
		{
			_db = db;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			List<Contact> contacts = _db.Contacts.Where(c=>c.Read==false).OrderByDescending(c => c.Date).ToList();
			List<Sale> sales = _db.Sales.Include(s=>s.AppUser).Where(s => s.Completed == false).OrderByDescending(s => s.Date).ToList();
			AdminVM model = new AdminVM
			{
				Contacts = contacts,
				Sales = sales
			};
			return View(await Task.FromResult(model));
		}
	}
}
