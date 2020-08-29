﻿using System;
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
    public class SalesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SalesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Sale> sales = _db.Sales.Include(s => s.AppUser).Include(s => s.SaleBooks).Where(s=>s.Completed==false).OrderByDescending(s=>s.Id).ToList();
            return View(sales);
        }
        public IActionResult CompletedSales(int page=1)
        {
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Sales.Where(s => s.Completed == false).Count() / 16);
            List<Sale> sales = _db.Sales.Include(s => s.AppUser).Include(s => s.SaleBooks).Where(s => s.Completed == false).OrderByDescending(s => s.Id).Skip((page-1)*16).Take(16).ToList();
            return View(sales);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Sale sale = _db.Sales.Include(s => s.AppUser).ThenInclude(a => a.UserDetail).Include(s => s.SaleBooks).ThenInclude(sb => sb.Book).ThenInclude(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefault(s => s.Id == id);
            if (sale == null) return NotFound();
            return View(sale);
        }
    }
}