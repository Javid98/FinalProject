using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.BakumozAdminPanel.ViewComponents
{
	public class AdminHeadTagViewComponent : ViewComponent
	{
		private readonly ApplicationDbContext _db;
		public AdminHeadTagViewComponent(ApplicationDbContext db)
		{
			_db = db;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			Bio bio = _db.Bios.FirstOrDefault();
			return View(await Task.FromResult(bio));
		}
	}
}
